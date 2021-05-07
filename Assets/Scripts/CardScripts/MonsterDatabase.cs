// Written by: Damien Carlson
// Written on: 4/26/2021

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;
using Assets.Scripts.CardFunctions.Cards;

public class MonsterDatabase : MonoBehaviour
{
    // Properties =====================================================================================================================

    public static List<Monster> aListOfMonsters = new List<Monster>();
    public static int cardCounter = 0;

    // Methods ========================================================================================================================

    void Awake()
    {
        // Variable order: string ID, sprite ImagePath, string Name, string Description, int Attack, int Health 
        aListOfMonsters.Add(new Zombie());
        aListOfMonsters.Add(new DireWolf());
        aListOfMonsters.Add(new DungeonBoss());
        aListOfMonsters.Add(new Goblin());
        aListOfMonsters.Add(new Ork());
        aListOfMonsters.Add(new OrkBattlemaster());
        aListOfMonsters.Add(new OrkHealer());
        aListOfMonsters.Add(new Rat());
        aListOfMonsters.Add(new Skeleton());
        aListOfMonsters.Add(new SkeletonArcher());
        aListOfMonsters.Add(new SkeletonWarrior());
        aListOfMonsters.Add(new SkeletonWarriorArcher());
        aListOfMonsters.Add(new Slime());
    }
}
