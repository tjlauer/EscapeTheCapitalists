// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Punch:Spell
    {
        public Punch()
        {
            Name = "Punch";
            CardText = "Deal 1 damage to an enemy";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 1;
            SpellDamage = 1;
        }
    }
}
