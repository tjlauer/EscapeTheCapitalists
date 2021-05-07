// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Rat:Monster
    {
        public Rat()
        {
            Name = "Rat";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 0;//this costs 0
            TotalHealth = 1;
            DamageSustained = 0;
            Attack = 1;
        }
    }
}
