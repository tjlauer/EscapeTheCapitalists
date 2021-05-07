// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Banshee:Minion
    {
        public Banshee()
        {
            Name = "Banshee";
            CardText = "Confusion";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 8;
            TotalHealth = 8;
            DamageSustained = 0;
            Attack = 4;
        }
    }
}
