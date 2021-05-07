// Created by: Damien Carlson
// Created on: 4/29/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleWinScreen : MonoBehaviour
{
    // Properties =====================================================================================================================

    public GameObject CardSlot;
    public GameObject MinionCard;
    public GameObject SpellCard;
    public GameObject Button;
    GameObject Prize;
    MinionStatFiller newMinion;
    SpellStatFiller newSpell;

    int coinFlip;

    // Methods ========================================================================================================================

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShowVictoryScreen()
    {
        yield return new WaitForSeconds(3);

        gameObject.SetActive(true);
        StartCoroutine(SlowYourRoll());
    }

    IEnumerator SlowYourRoll()
    {
        yield return new WaitForSeconds(3);

        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.2f);

            RollPrize();
        }

        Prize = CardSlot.transform.GetChild(0).gameObject;

        if (Prize.name == "MinionTemplate(Clone)")
        {
            newMinion = MinionCard.GetComponent<MinionStatFiller>();

            SharedResources.playerDeck.Add(newMinion.thisCard[0]);
        }
        else if (Prize.name == "SpellTemplate(Clone)")
        {
            newSpell = MinionCard.GetComponent<SpellStatFiller>();

            SharedResources.playerDeck.Add(newSpell.thisCard[0]);
        }
        Debug.Log("Card added: " + Prize.name);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)

        Button.SetActive(true);
    }

    public void RollPrize()
    {
        coinFlip = Random.Range(0, 2);

        if (coinFlip == 0 && PlayerDeck.instanceOfPlayerMinionDeck.Count > 0)
        {
            Destroy(CardSlot.transform.GetChild(0).gameObject);
            GameObject playerCard = Instantiate(MinionCard, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardSlot.transform, false);
        }
        else if (coinFlip == 1 && PlayerDeck.instanceOfPlayerSpellDeck.Count > 0)
        {
            Destroy(CardSlot.transform.GetChild(0).gameObject);
            GameObject playerCard = Instantiate(SpellCard, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardSlot.transform, false);
        }
        else if (PlayerDeck.instanceOfPlayerMinionDeck.Count <= 0 && PlayerDeck.instanceOfPlayerSpellDeck.Count <= 0)
        {

        }
        else
        {
            try { return; }
            finally { RollPrize(); }
        }
    }

    public void ContinueAdventure()
    {
        SharedResources.AbleToSpawnEnemies = false;
        Debug.Log("SharedResources.levelToLoad = " + SharedResources.levelToLoad);
        SceneManager.LoadScene(SharedResources.levelToLoad);
    }

    
}
