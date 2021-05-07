// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Adventurer:Minion
    {
        public Adventurer()
        {
            Name = "Adventurer";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 1;
            TotalHealth = 2;
            DamageSustained = 0;
            Attack = 1;
        }
    }
}
