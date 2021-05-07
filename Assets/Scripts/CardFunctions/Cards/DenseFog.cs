// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class DenseFog:Spell
    {
        public DenseFog()
        {
            Name = "Dense Fog";
            CardText = "All enemy monsters have a 50% chance to not attack for 2 turns";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 7;
            SpellDamage = 2; //(refers to turn duration)
        }
    }
}
