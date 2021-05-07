// Written by: Damien Carlson
// Created on: 4/26/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    // Properties =====================================================================================================================

    MinionStatFiller ThisMinion;
    MonsterStatFiller ThisMonster;

    string thisCard;

    //public int incomingDamage = 0;

    // Methods ========================================================================================================================

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.ToString() == "MinionTemplate(Clone) (UnityEngine.GameObject)")
        {
            ThisMinion = gameObject.GetComponent<MinionStatFiller>();
            thisCard = "Minion";
        }
        else if (gameObject.ToString() == "MonsterTemplate(Clone) (UnityEngine.GameObject)")
        {
            ThisMonster = gameObject.GetComponent<MonsterStatFiller>();
            thisCard = "Monster";
        }
    }

    public void DealDamage(int incomingDamage)
    {
        if (thisCard == "Minion")
        {
            ThisMinion.totalHealth -= incomingDamage;
            ThisMinion.UpdateStats();

        }
        else if (thisCard == "Monster")
        {
            ThisMonster.totalHealth -= incomingDamage;
            ThisMonster.UpdateStats();
        }
    }
}
