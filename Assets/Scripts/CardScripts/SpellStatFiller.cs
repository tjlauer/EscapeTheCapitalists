// Written by: Damien Carlson
// Created on: 4/28/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets.Scripts.CardFunctions;

public class SpellStatFiller : MonoBehaviour
{
    // Properties =====================================================================================================================
    public List<Spell> thisCard = new List<Spell>();
    
    public Image imgArt;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtDescription;
    public TextMeshProUGUI txtManaCost;
    public TextMeshProUGUI txtAttack;
    public GameObject fadeCard;

    int thisID;
    public string id;
    public Sprite thisSprite;
    public string cardName;
    public int manaCost;
    public int attack;
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
        thisID = Random.Range(0, PlayerDeck.instanceOfPlayerSpellDeck.Count);

        if (ZoomScript.tryingToZoom == false)
            CreateCard();
    }

    public void CreateCard()
    {
        thisCard.Add(PlayerDeck.instanceOfPlayerSpellDeck[thisID]);

        cardName = thisCard[0].Name;
        manaCost = thisCard[0].CardCost;
        attack = thisCard[0].SpellDamage;
        cardDescription = thisCard[0].CardText;
        thisSprite = thisCard[0].ImgPath;

        txtName.text = cardName;
        imgArt.sprite = thisSprite;
        txtDescription.text = cardDescription;
        txtManaCost.text = ""+manaCost;
        txtAttack.text = ""+attack;

        PlayerDeck.instanceOfPlayerSpellDeck.RemoveAt(thisID);
    }
}
