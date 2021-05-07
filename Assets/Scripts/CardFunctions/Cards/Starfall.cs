// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Starfall:Minion
    {
        public Starfall()
        {
            Name = "Starfall";
            CardText = "Deals 6 damge to ALL charaters when played";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 9;
            TotalHealth = 5;
            DamageSustained = 0;
            Attack = 6;
        }
}
}
