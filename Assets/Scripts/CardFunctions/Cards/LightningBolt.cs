// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class LightningBolt:Spell
    {
        public LightningBolt()
        {
            Name = "Lightning Bolt";
            CardText = "Deal 4 damage to the targeted monster.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 3;
            SpellDamage = 4;
        }
    }
}
