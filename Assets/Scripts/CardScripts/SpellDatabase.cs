// Written by: Dustin Frandle
// Written on: 4/27/21

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class SpellDatabase : MonoBehaviour
{
    // Properties =====================================================================================================================

    public static List<Spell> aListOfSpells = new List<Spell>();
    public static int cardCounter = 0;

    // Methods ========================================================================================================================

    void Awake()
    {
        // Variable order: string ID, sprite ImagePath, string Name, string Description, int ManaCost, int Attack, int Health 
        aListOfSpells.Add(new ChainLightning());
        aListOfSpells.Add(new DenseFog());
        aListOfSpells.Add(new Duplicate());
        aListOfSpells.Add(new Fireball());
        aListOfSpells.Add(new FrostBlast());
        aListOfSpells.Add(new LightHeal());
        aListOfSpells.Add(new LightningBolt());
        aListOfSpells.Add(new MaxHeal());
        aListOfSpells.Add(new Promotion());
        aListOfSpells.Add(new Punch());
        aListOfSpells.Add(new SteamBath());
        aListOfSpells.Add(new WindSlash());
    }
}
