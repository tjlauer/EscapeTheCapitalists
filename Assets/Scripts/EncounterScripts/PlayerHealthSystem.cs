// Written by: Damien Carlson
// Created on: 04/27/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthSystem : MonoBehaviour
{
    // Properties =====================================================================================================================

    public TextMeshProUGUI PlayerHealth;

    // Methods ========================================================================================================================

    public void DamagePlayerHealth(int incomingDamage)
    {
        GameManager.playerHealth -= incomingDamage;

        UpdateHealthBar();
    }

    public void GivePlayerHealth(int incomingHealth)
    {
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        PlayerHealth.text = "Health: " + GameManager.playerHealth;

        if (GameManager.playerHealth <= 0)
        {
            // Player loses
        }
    }
}
