// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class DireWolf:Monster
    {
        public DireWolf()
        {
            Name = "Dire Wolf";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            TotalHealth = 2;
            DamageSustained = 0;
            Attack = 4;
        }
    }
}
