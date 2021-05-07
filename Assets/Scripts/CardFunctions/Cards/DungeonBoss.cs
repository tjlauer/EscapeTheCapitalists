// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class DungeonBoss:Monster
    {
        public DungeonBoss()
        {
            Name = "Dungeon Boss";
            CardText = "Spawns two random monsters every turn, takes 1/2 damage if this is not the only enemy monster";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 20;
            TotalHealth = 45;
            DamageSustained = 0;
            Attack = 20;
        }
    }
}
