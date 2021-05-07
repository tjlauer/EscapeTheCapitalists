// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Fireball:Spell
    {
        public Fireball()
        {
            Name = "Fireball";
            CardText = "Deal 2 damage, Burning";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 4;
            SpellDamage = 2;
        }
    }
}
