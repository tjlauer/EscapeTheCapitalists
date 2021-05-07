// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions
{
	public class FrostGiant:Minion
	{
        public FrostGiant()
        {
            Name = "Frost Giant";
            CardText = "AOE, also aplies Freezing to damaged eneimes.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 10;
            TotalHealth = 12;
            DamageSustained = 0;
            Attack = 4;
        }
    }
}