// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Fenrir:Minion
    {
        public Fenrir()
        {
            Name = "Fenrir";
            CardText = "Gains +1/1 for each other Fenrir in play";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 4;
            TotalHealth = 4;
            DamageSustained = 0;
            Attack = 3;
        }
    }
}
