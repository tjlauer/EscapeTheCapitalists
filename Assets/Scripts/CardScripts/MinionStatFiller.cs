// Written by: Damien Carlson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets.Scripts.CardFunctions;

public class MinionStatFiller : MonoBehaviour
{
    // Properties =====================================================================================================================
    public List<Minion> thisCard = new List<Minion>();
    
    public Image imgArt;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtDescription;
    public TextMeshProUGUI txtManaCost;
    public TextMeshProUGUI txtAttack;
    public TextMeshProUGUI txtHealth;
    public GameObject fadeCard;

    int thisID;
    public string id;
    public Sprite thisSprite;
    public string cardName;
    public int manaCost;
    public int attack;
    public int totalHealth;
    public int damage;
    public string cardDescription;

    public bool hasAttacked = false;
    public bool isSummoned = false;

    public CardZoom ZoomScript;

    // Methods ========================================================================================================================

    private void Awake()
    {
        ZoomScript = gameObject.GetComponent<CardZoom>();
    }

    void Start()
    {
        thisID = Random.Range(0, PlayerDeck.instanceOfPlayerMinionDeck.Count);

        if (ZoomScript.tryingToZoom == false)
            CreateCard();
    }

    public void CreateCard()
    {
        thisCard.Add(PlayerDeck.instanceOfPlayerMinionDeck[thisID]);

        cardName = thisCard[0].Name;
        manaCost = thisCard[0].CardCost;
        attack = thisCard[0].Attack;
        totalHealth = thisCard[0].TotalHealth;
        damage = thisCard[0].DamageSustained;
        cardDescription = thisCard[0].CardText;
        thisSprite = thisCard[0].ImgPath;

        txtName.text = cardName;
        imgArt.sprite = thisSprite;
        txtDescription.text = cardDescription;
        txtManaCost.text = ""+manaCost;
        txtAttack.text = ""+attack;
        txtHealth.text = ""+totalHealth;

        PlayerDeck.instanceOfPlayerMinionDeck.RemoveAt(thisID);
    }

    public void UpdateStats()
    {
        txtAttack.text = "" + attack;
        txtHealth.text = "" + totalHealth;

        if (totalHealth <= 0)
        {
            TurnSystem.aListOfMinionsInPlay.Remove(gameObject);

            if (hasAttacked == true)
            {
                TurnSystem.aListOfMinionsThatAttacked.Remove(gameObject);
            }
            //Debug.Log("List count from UpdateStats() = " + TurnSystem.aListOfMinionsThatAttacked.Count);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
            Destroy(gameObject);
        }
    }
}
