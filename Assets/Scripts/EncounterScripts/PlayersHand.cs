// Written by: Damien Carlson
// Created on: 04/08/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class PlayersHand : MonoBehaviour
{
    // Properties =====================================================================================================================

    public GameObject PlayerMinion;
    public GameObject PlayerSpell;
    public GameObject PlayerHand;

    List<Card> drawnCard = new List<Card>();

    public static int handCount;
    int coinFlip;

    // Methods ========================================================================================================================

    //public void DrawCard()
    //{
    //    if (handCount < 7)
    //    {
    //        int rng = Random.Range(0, PlayerDeck.deckSize);

    //        if (PlayerDeck.deckSize > 0)
    //        {
    //            drawnCard.Add(PlayerDeck.instanceOfPlayerDeck[rng]);

    //            PlayerDeck.instanceOfPlayerDeck.RemoveAt(rng);
    //            Debug.Log("CardType = " + drawnCard[0].GetType().ToString());
    //            if (drawnCard[0].GetType().ToString() == "Minion")
    //            {
    //                GameObject playerCard = Instantiate(PlayerMinion, new Vector3(0, 0, 0), Quaternion.identity);
    //                playerCard.transform.SetParent(PlayerHand.transform, false);
    //            }
    //            else if (drawnCard[0].GetType().ToString() == "Spell")
    //            {
    //                GameObject playerCard = Instantiate(PlayerSpell, new Vector3(0, 0, 0), Quaternion.identity);
    //                playerCard.transform.SetParent(PlayerHand.transform, false);
    //            }

    //            handCount++;
    //            PlayerDeck.deckSize--;
    //        }
    //    }
    //}

    public void DrawCard()
    {
        if (handCount < 7)
        {
            coinFlip = Random.Range(0, 2);

            if (coinFlip == 0 && PlayerDeck.instanceOfPlayerMinionDeck.Count > 0)
            {
                GameObject playerCard = Instantiate(PlayerMinion, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerHand.transform, false);
            }
            else if (coinFlip == 1 && PlayerDeck.instanceOfPlayerSpellDeck.Count > 0)
            {
                GameObject playerCard = Instantiate(PlayerSpell, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerHand.transform, false);
            }
            else if (PlayerDeck.instanceOfPlayerMinionDeck.Count <= 0 && PlayerDeck.instanceOfPlayerSpellDeck.Count <= 0)
            {

            }
            else
            {
                try { return; }
                finally { DrawCard(); }
            }

            handCount++;
            PlayerDeck.deckSize--;
        }

    }
}
