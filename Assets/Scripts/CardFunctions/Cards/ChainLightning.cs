// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class ChainLightning:Spell
    {
        public ChainLightning()
        {
            Name = "Chain Lightning";
            CardText = "6 Damage, AOE";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 7;
            SpellDamage = 6;
        }
    }
}
