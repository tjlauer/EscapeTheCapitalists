// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class SkeletonWarrior:Monster
    {
        public SkeletonWarrior()
        {
            Name = "Skeleton Warrior";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 5;
            TotalHealth = 5;
            DamageSustained = 0;
            Attack = 6;
        }
    }
}
