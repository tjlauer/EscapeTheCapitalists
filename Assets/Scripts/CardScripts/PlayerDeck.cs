// Written by: Damien Carlson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class PlayerDeck : MonoBehaviour
{
    // Properties =====================================================================================================================

    public static List<Minion> instanceOfPlayerMinionDeck = new List<Minion>();
    public static List<Spell> instanceOfPlayerSpellDeck = new List<Spell>();

    public static List<Card> instanceOfPlayerDeck = new List<Card>();

    public static int deckSize;

    public GameObject CardInDeck1;
    public GameObject CardInDeck2;
    public GameObject CardInDeck3;
    public GameObject CardInDeck4;


    // Methods ========================================================================================================================

    void Awake()
    {
        instanceOfPlayerMinionDeck = GameManager.playerMinionDeck;
        instanceOfPlayerSpellDeck = GameManager.playerSpellDeck;

        instanceOfPlayerDeck = SharedResources.playerDeck;
        
    }
    private void Start()
    {
        deckSize = instanceOfPlayerDeck.Count;
    }


    public void UpdateDeckDisplay()
    {
        if(deckSize < 4)
        {
            CardInDeck4.SetActive(false);
        }
        if (deckSize < 3)
        {
            CardInDeck3.SetActive(false);
        }
        if (deckSize < 2)
        {
            CardInDeck2.SetActive(false);
        }
        if (deckSize < 1)
        {
            CardInDeck1.SetActive(false);
        }
    }
}
