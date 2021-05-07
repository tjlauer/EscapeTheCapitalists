// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class SkeletonWarriorArcher:Monster
    {
        public SkeletonWarriorArcher()
        {
            Name = "Skeleton Warrior Archer";
            CardText = "Cannot attcak, deals 3 damage to a random enemy each turn";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 6;
            TotalHealth = 5;
            DamageSustained = 0;
            Attack = 3;
        }
    }
}
