// Written by: Damien Carlson
// Created on: 4/25/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class GameManager : MonoBehaviour
{
    // Properties =====================================================================================================================

    public static GameManager instance;

    public static List<Minion> playerMinionDeck = new List<Minion>();
    public static List<Spell> playerSpellDeck = new List<Spell>();
    public static List<Card> databaseOfAllCards = new List<Card>();

    // I'm putting this here in case we want to implement healing later. For now, the health will always reset to 100 before each encounter
    public static int playerHealth;

    public static List<string> aListOfTheEcounteredMonstersIDS = new List<string>();

    // Methods ========================================================================================================================

    private void Awake()
    {
        playerHealth = SharedResources.playerHealth;
        playerMinionDeck = MinionDatabase.aListOfMinions;
        playerSpellDeck = SpellDatabase.aListOfSpells;
        //databaseOfAllCards = MinionDatabase.aListOfMinions;

        MakeSingleton();
    }


    // Makes sure there is only one instance of this script.
    // This will ensure that the values stored in this file will stay consistent throughout the entire game (all scenes).
    public void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject); 
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
