// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class EmergencyBarricade:Minion
    {
        public EmergencyBarricade()
        {
            Name = "Emergency Barricade";
            CardText = "Deployed, Protect";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 5;
            TotalHealth = 10;
            DamageSustained = 0;
            Attack = 0;
        }
    }
}
