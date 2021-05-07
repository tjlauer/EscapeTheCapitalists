// Created by: Damien Carlson
// Created on 4/26/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnSystem : MonoBehaviour
{
    // Properties =====================================================================================================================

    // Objects
    public Button MainButton;
    public TextMeshProUGUI ButtonText;
    public GameObject UsedCard;
    public GameObject AttackingMonster;
    public GameObject MinionGettingAttacked;
    public GameObject WinScreen;

    // Scripts
    public ManaSystem ManaScript;
    public PlayerHealthSystem PlayerHealthScript;
    public PlayersHand HandScript;
    MinionStatFiller MinionsStats;
    MinionStatFiller TargetedMinionsStats;
    MonsterStatFiller MonstersStats;
    DamageSystem MinionsDamageScript;
    DamageSystem MonstersDamageScript;
    BattleWinScreen WinScreenScript;

    // Variables
    public enum GameState { PlayersTurn, EnemysTurn};
    public static GameState currentPhase = GameState.PlayersTurn;

    public static List<GameObject> aListOfMinionsThatAttacked = new List<GameObject>();
    public static List<GameObject> aListOfMinionsInPlay = new List<GameObject>();
    public static List<GameObject> aListOfMonstersInPlay = new List<GameObject>();

    // Methods ========================================================================================================================

    public void ChangePhase() // This is triggered when the button is pressed.
    {
        if (currentPhase == GameState.PlayersTurn)
        {
            MainButton.interactable = false;
            ButtonText.text = "Wait for Opponent";

            currentPhase = GameState.EnemysTurn;

            StartEnemysTurn();
        }
    }

    public void StartEnemysTurn()
    {
        for (int i = 0; i < aListOfMonstersInPlay.Count; i++)
        {
            AttackingMonster = aListOfMonstersInPlay[i];
            MonstersStats = AttackingMonster.GetComponent<MonsterStatFiller>();
            MonstersDamageScript = AttackingMonster.GetComponent<DamageSystem>();

            //Debug.Log("i = " + i + "Attacking Monster = " + MonstersStats.cardName);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)

            InitiateEnemyAttack();
        }

        StartNewTurn();
    }

    public void StartNewTurn()
    {
        //Debug.Log("List count from StartNewTurn() = " + aListOfMinionsThatAttacked.Count);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        if (aListOfMinionsThatAttacked.Count > 0)
        {
            for (int i = 0; i < aListOfMinionsThatAttacked.Count; i++)
            {
                try
                {
                    UsedCard = aListOfMinionsThatAttacked[i];
                    MinionsStats = UsedCard.GetComponent<MinionStatFiller>();

                    MinionsStats.hasAttacked = false;
                    MinionsStats.fadeCard.SetActive(false);
                }
                catch (System.Exception){ }//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
            }
            aListOfMinionsThatAttacked.Clear();
        }

        currentPhase = GameState.PlayersTurn;

        ManaScript.ResupplyMana();
        HandScript.DrawCard();

        ButtonText.text = "End Turn";
        MainButton.interactable = true;
    }

    public void InitiateEnemyAttack()
    {
        if (aListOfMinionsInPlay.Count > 0)
        {
            MinionGettingAttacked = aListOfMinionsInPlay[Random.Range(0, aListOfMinionsInPlay.Count - 1)];
            //Debug.Log("Minions in play = " + aListOfMinionsInPlay.Count);//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
            MinionsDamageScript = MinionGettingAttacked.GetComponent<DamageSystem>();
            TargetedMinionsStats = MinionGettingAttacked.GetComponent<MinionStatFiller>();

            MinionsDamageScript.DealDamage(MonstersStats.attack);
            MonstersDamageScript.DealDamage(TargetedMinionsStats.attack);
        }
        else if (aListOfMinionsInPlay.Count == 0)
        {
            PlayerHealthScript.DamagePlayerHealth(MonstersStats.attack);
        }

        //Debug.Log("Monster attacking: " + MonstersStats.cardName + "\n Damage being dealt: " + MonstersStats.attack + "Minion Attacked: " +//%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
          //  TargetedMinionsStats.cardName); 
    }

    public void CheckWinConditions()
    {
        if (aListOfMonstersInPlay.Count <= 0)
        {
            //Player Wins!!!
            WinScreenScript = WinScreen.GetComponent<BattleWinScreen>();

            StartCoroutine(WinScreenScript.ShowVictoryScreen());

        }
    }
}
