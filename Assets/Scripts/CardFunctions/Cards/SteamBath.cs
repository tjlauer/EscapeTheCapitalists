// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class SteamBath:Spell
    {
        public SteamBath()
        {
            Name = "Steam Bath";
            CardText = "Deal 1 Burning damage to all enemies.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            SpellDamage = 1;
        }
    }
}
