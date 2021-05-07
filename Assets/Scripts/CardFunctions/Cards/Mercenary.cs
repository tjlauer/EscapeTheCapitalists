// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Mercenary:Minion
    {
        public Mercenary()
        {
            Name = "Mercenary";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            TotalHealth = 3;
            DamageSustained = 0;
            Attack = 2;
        }
    }
}
