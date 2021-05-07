// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class FireElemental:Minion
    {
        public FireElemental()
        {
            Name = "Fire Elemental";
            CardText = "Burning";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 5;
            TotalHealth = 4;
            DamageSustained = 0;
            Attack = 2;
        }
    }
}
