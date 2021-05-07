// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class IceGolem:Minion
    {
        public IceGolem()
        {
            Name = "Ice Golem";
            CardText = "Freezing";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 6;
            TotalHealth = 6;
            DamageSustained = 0;
            Attack = 2;
        }
    }
}
