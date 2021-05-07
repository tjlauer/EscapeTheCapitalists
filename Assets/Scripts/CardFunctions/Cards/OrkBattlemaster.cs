// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class OrkBattlemaster:Monster
    {
        public OrkBattlemaster()
        {
            Name = "Ork Battlemaster";
            CardText = "";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 7;
            TotalHealth = 5;
            DamageSustained = 0;
            Attack = 10;
        }
    }
}
