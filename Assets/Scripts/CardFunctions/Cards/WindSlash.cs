// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class WindSlash:Spell
    {
        public WindSlash()
        {
            Name = "Wind Slash";
            CardText = "Deal 5 damage.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 5;
            SpellDamage = 5;
        }
    }
}
