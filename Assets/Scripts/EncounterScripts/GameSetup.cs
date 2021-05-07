// Written by: Damien Carlson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    // Properties  =====================================================================================================================

    public GameObject MonsterCard;
    public GameObject EnemyField;

    public ManaSystem ManaScript;
    public PlayersHand HandScript;
    public PlayerHealthSystem HealthScript;

    public static int monsterCount = 3;

    // Methods ========================================================================================================================

    void Start()
    {
        PlayersHand.handCount = 0;
        ManaScript.ResupplyMana();
        HealthScript.UpdateHealthBar();

        // Places 3 Monsters on the field
        for (var i = 0; i < Random.Range(2, 5); i++)
        {
            GameObject enemyCard = Instantiate(MonsterCard, new Vector3(0, 0, 0), Quaternion.identity);
            enemyCard.transform.SetParent(EnemyField.transform, false);

            TurnSystem.aListOfMonstersInPlay.Add(enemyCard);
        }

        // Draws random cards from the deck
        for (var i = 0; i < 5; i++)
        {
            HandScript.DrawCard();
        }
    }
}
