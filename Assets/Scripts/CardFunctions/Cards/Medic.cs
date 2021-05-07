// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Medic:Minion
    {
        public Medic()
        {
            Name = "Medic";
            CardText = "When played, choose a character and restore 4 Health.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            TotalHealth = 3;
            DamageSustained = 0;
            Attack = 3;
        }
    }
}
