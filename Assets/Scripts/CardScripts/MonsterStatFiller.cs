// Written by: Damien Carlson
// Created on: 4/26/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class MonsterStatFiller : MonoBehaviour
{
    // Properties =====================================================================================================================

    List<Monster> thisCard = new List<Monster>();

    public Image imgArt;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtDescription;
    public TextMeshProUGUI txtAttack;
    public TextMeshProUGUI txtHealth;

    public GameObject EncounterSystems;
    TurnSystem TurnSystemScript;

    int thisID;
    public Sprite thisSprite;
    public string cardName;
    public int attack;
    public int totalHealth;
    public int damage;
    public string cardDescription;
    public static bool bossSpawned = false;

    private CardZoom ZoomScript;

    // Methods ========================================================================================================================

    private void Awake()
    {
        ZoomScript = gameObject.GetComponent<CardZoom>();
        EncounterSystems = GameObject.Find("EncounterSystems");
        TurnSystemScript = EncounterSystems.GetComponent<TurnSystem>();
    }

    void Start()
    {
        thisID = Random.Range(0, MonsterDatabase.aListOfMonsters.Count);

        //Debug.Log("Index chosen = " + thisID); //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        //Debug.Log("Size of aListOfMonsters = " + MonsterDatabase.aListOfMonsters.Count);
        //Debug.Log("Card Chosen: " + MonsterDatabase.aListOfMonsters[thisID].Name);

        if (ZoomScript.tryingToZoom == false)
            CreateMonster();

    }

    public void CreateMonster()
    {
        thisCard.Add(MonsterDatabase.aListOfMonsters[thisID]);

        if (thisCard[0].Name == "Dungeon Boss" && SharedResources.levelToLoad != "Boss")
        {
            thisCard.RemoveAt(thisID);
             
            try
            {
                return;
            }
            finally
            {
                CreateMonster();
            }

        }
        else if (SharedResources.levelToLoad == "Boss" && bossSpawned == false)
        {
            thisCard.Clear();
            thisCard.Add(new DungeonBoss());

            bossSpawned = true;
        }


        cardName = thisCard[0].Name;
        attack = thisCard[0].Attack;
        totalHealth = thisCard[0].TotalHealth;
        damage = thisCard[0].DamageSustained;
        cardDescription = thisCard[0].CardText;
        //thisSprite = thisCard[0].ImgPath;

        txtName.text = cardName;
        //imgArt.sprite = thisSprite;
        txtDescription.text = cardDescription;
        txtAttack.text = ""+attack;
        txtHealth.text = ""+totalHealth;

        MonsterDatabase.aListOfMonsters.RemoveAt(thisID);
    }

    public void UpdateStats()
    {
        txtAttack.text = attack.ToString();
        txtHealth.text = totalHealth.ToString();

        if (totalHealth <= 0)
        {
            Destroy(gameObject);

            TurnSystem.aListOfMonstersInPlay.Remove(gameObject);

            TurnSystemScript.CheckWinConditions();
        }
    }

}
