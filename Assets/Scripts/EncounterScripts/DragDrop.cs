// Written by: Damien Carlson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    // Properties =====================================================================================================================

    GameObject EncounterSystems;
    GameObject Canvas;
    GameObject dropZone;
    GameObject startParent;

    ManaSystem manaScript;
    MinionStatFiller ThisMinion;
    SpellStatFiller ThisSpell;
    DamageSystem MinionsDamageScript;
    MonsterStatFiller TargetMonster;
    DamageSystem MonstersDamageScript;
    
    bool isDragging = false;
    bool isOverDropZone = false;
    bool isOverValidTarget;
    Vector2 startPosition;
    string minion = "MinionTemplate(Clone)";
    string spell = "SpellTemplate(Clone)";
    string monster = "MonsterTemplate(Clone)";

    enum cardType { Minion, Spell };
    cardType thisCardsType;

    // Methods ========================================================================================================================

    private void Awake()
    {
        Canvas = GameObject.Find("Main Canvas");
        EncounterSystems = GameObject.Find("EncounterSystems");
        manaScript = EncounterSystems.GetComponent<ManaSystem>();

        if (gameObject.name == minion)
        {
            ThisMinion = gameObject.GetComponent<MinionStatFiller>();
            MinionsDamageScript = ThisMinion.GetComponent<DamageSystem>();
        }
        else if (gameObject.name == spell)
        {
            ThisSpell = gameObject.GetComponent<SpellStatFiller>();
        }

        isOverValidTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Makes card follow mouse when dragging
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }

    // These two methods restrict where you can place cards to the dropzone.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (TurnSystem.currentPhase == TurnSystem.GameState.PlayersTurn && collision.gameObject.name == monster && (gameObject.name == minion || gameObject.name == spell))
        {
            isOverValidTarget = true;
            TargetMonster = collision.gameObject.GetComponent<MonsterStatFiller>();
            MonstersDamageScript = collision.gameObject.GetComponent<DamageSystem>();
        }

        //Debug.Log("The object you collided with is: " + collision.gameObject.ToString()); //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        if (collision.gameObject.name == "DropZone")
        {
            isOverDropZone = true;
            dropZone = collision.gameObject;
        }
    }
    
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (TurnSystem.currentPhase == TurnSystem.GameState.PlayersTurn && collision.gameObject.name == monster)
        {
            isOverValidTarget = false;
        }

        if (collision.gameObject.name == "DropZone")
        {
            isOverDropZone = false;
            dropZone = null;
        }
    }

    public void StartDrag()
    {
        // this makes the card overlay everything
        startParent = transform.parent.gameObject;

        // this saves the starting position of the card
        startPosition = transform.position;

        if (TurnSystem.currentPhase == TurnSystem.GameState.PlayersTurn && (startParent.name == "PlayerHand" || startParent.name == "DropZone"))
        {
            // Setting this to true allows you to drag the card.
            isDragging = true;
        }
       
    }

    public void EndDrag()
    {
        isDragging = false;

        if (TurnSystem.currentPhase == TurnSystem.GameState.PlayersTurn && gameObject.name == minion)
        {
            if (isOverDropZone && ThisMinion.isSummoned == false && TurnSystem.aListOfMinionsInPlay.Count <= 10)
            {
                SummonMinion();
            }
            else if (isOverValidTarget && ThisMinion.hasAttacked == false && ThisMinion.isSummoned == true)
            {
                AttackWithMinion();
            }
            else
            {
                ResetToPreviousLocation();
            }
        }
        else if (TurnSystem.currentPhase == TurnSystem.GameState.PlayersTurn && gameObject.name == spell)
        {
            AttackWithSpell();
        }
        else
        {
            ResetToPreviousLocation();
        }

        isOverDropZone = false;
    }

    public void SummonMinion()
    {
        bool enoughMana = manaScript.SpendMana(ThisMinion.manaCost);

        if (enoughMana)
        {
            // This positions the card in the drop zone when dropped in legal space and you have enough mana.
            transform.SetParent(dropZone.transform, false);

            ThisMinion.isSummoned = true;
            PlayersHand.handCount--;

            TurnSystem.aListOfMinionsInPlay.Add(gameObject);
        }
        else
        {
            ResetToPreviousLocation();
        }
    }

    public void AttackWithMinion()
    {
        MonstersDamageScript.DealDamage(ThisMinion.attack);
        MinionsDamageScript.DealDamage(TargetMonster.attack);

        ThisMinion.hasAttacked = true;
        TurnSystem.aListOfMinionsThatAttacked.Add(gameObject);
        //Debug.Log("aListOfMinionsThatAttacked = " + TurnSystem.aListOfMinionsThatAttacked.Count);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        ThisMinion.fadeCard.SetActive(true);

        ResetToPreviousLocation();
    }

    public void AttackWithSpell()
    {
        bool enoughMana = manaScript.SpendMana(ThisSpell.manaCost);

        if (enoughMana && isOverValidTarget)
        {
            MonstersDamageScript.DealDamage(ThisSpell.attack);

            PlayersHand.handCount--;
            Destroy(gameObject);
        }
        else
        {
            ResetToPreviousLocation();
        }
    }

    public void ResetToPreviousLocation()
    {
        // This returns the card back to its starting position if dropped in illegal space.
        transform.position = startPosition;
        // This resets the overlay
        transform.SetParent(startParent.transform, false);
    }
}
