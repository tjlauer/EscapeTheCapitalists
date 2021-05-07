// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class SkeletonArcher:Monster
    {
        public SkeletonArcher()
        {
            Name = "Skeleton Archer";
            CardText = "Cannot attack, deals 2 damage to a random enemy each turn";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            TotalHealth = 2;
            DamageSustained = 0;
            Attack = 2;
        }
    }
}
