// Created by: Braxton Fair
// Created on: 03/31/2021

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class MainMenuController : MonoBehaviour
{
    public GameObject FrontPanel;

    // Load the main dungeon
    public void StartGame()
    {
        // Populate the players hand with 10 random cards

        // Pick 10 random cards
        for (var idx = 0; idx < 10; idx++)
        {
            int coinFlip = Random.Range(0, 2);
            int count = SpellDatabase.aListOfSpells.Count;
            int randomSpells = Random.Range(0, count);
            int countMinions = MinionDatabase.aListOfMinions.Count;
            int randomMinions = Random.Range(0, countMinions);

            // Choose random Spell
            if (coinFlip == 0)
            {
                var card = SpellDatabase.aListOfSpells[randomSpells];

                SharedResources.playerDeck.Add(card);
            } 
            else if (coinFlip == 1) {
                var card = MinionDatabase.aListOfMinions[randomMinions];

                SharedResources.playerDeck.Add(card);
            }
        }

        SceneManager.LoadScene("E");
    }

    // Open the encounter scene
    public void Quit()
    {
        Application.Quit();
    }
}
