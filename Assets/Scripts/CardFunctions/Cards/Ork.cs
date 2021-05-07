// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Ork:Monster
    {
        public Ork()
        {
            Name = "Ork";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 4;
            TotalHealth = 3;
            DamageSustained = 0;
            Attack = 6;
        }
    }
}
