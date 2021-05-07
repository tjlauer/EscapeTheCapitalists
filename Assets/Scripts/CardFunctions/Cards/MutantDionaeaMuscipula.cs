// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class MutantDionaeaMuscipula:Minion
    {
        public MutantDionaeaMuscipula()
        {
            Name = "Mutant Dionaea Muscipula";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 4;
            TotalHealth = 2;
            DamageSustained = 0;
            Attack = 5;
        }
    }
}
