// Written by: Damien Carlson
// Written on: 4/25/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class MinionDatabase : MonoBehaviour
{
    // Properties =====================================================================================================================

    public static List<Minion> aListOfMinions = new List<Minion>();

    // Methods ========================================================================================================================

    void Awake()
    {
        // Variable order: string ID, sprite ImagePath, string Name, string Description, int ManaCost, int Attack, int Health 
        aListOfMinions.Add(new Adventurer());
        aListOfMinions.Add(new Banshee());
        aListOfMinions.Add(new Commander());
        aListOfMinions.Add(new EarthGolem());
        aListOfMinions.Add(new EmergencyBarricade());
        aListOfMinions.Add(new EnchantedArmor());
        aListOfMinions.Add(new Fenrir());
        aListOfMinions.Add(new FireElemental());
        aListOfMinions.Add(new FrostGiant());
        aListOfMinions.Add(new IceGolem());
        aListOfMinions.Add(new Medic());
        aListOfMinions.Add(new Mercenary());
        aListOfMinions.Add(new Starfall());
        aListOfMinions.Add(new UndeadKnight());
        aListOfMinions.Add(new VolcanicLizard());
    }
}
