// Written by: Damien Carlson
// Created on: 04/07/2021

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManaSystem : MonoBehaviour
{
    // Properties =====================================================================================================================

    public GameSetup GameSetup;
    public TextMeshProUGUI ManaStat;

    public static int maxMana;
    public static int manaSupply;
    public static int turnCounter = 0;
    public static bool playerCanAfford;

    //Methods ========================================================================================================================

    public void ResupplyMana()
    {
        turnCounter++;

        if (maxMana < 10)
        {
            maxMana = GameSetup.monsterCount + turnCounter;
            //maxMana += 40;//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Debug (Don't forget to remove this)
        }

        manaSupply = maxMana;
        UpdateManaBar();
    }

    public bool SpendMana(int cost)
    {
        playerCanAfford = false;

        if ((manaSupply - cost) >= 0)
        {
            playerCanAfford = true;
            manaSupply -= cost;
            UpdateManaBar();
        }
        else
        {
            UpdateManaBar();
        }
           

        return playerCanAfford;
    }

    public void UpdateManaBar()
    {
        ManaStat.text = "Mana: " + manaSupply + "/" + maxMana;
    }
}
