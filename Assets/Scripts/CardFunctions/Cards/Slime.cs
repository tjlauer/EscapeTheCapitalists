// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Slime:Monster
    {
        public Slime()
        {
            Name = "Slime";
            CardText = "Duplicates itself each turn";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 5;
            TotalHealth = 3;
            DamageSustained = 0;
            Attack = 3;
        }
    }
}
