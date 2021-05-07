// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class EarthGolem:Minion
    {
        public EarthGolem()
        {
            Name = "EarthGolem";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 4;
            TotalHealth = 6;
            DamageSustained = 0;
            Attack = 1;
        }
    }
}
