// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class MaxHeal:Spell
    {
        public MaxHeal()
        {
            Name = "Max Heal";
            CardText = "Restore 15 health to the player and their minions.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 10;
            SpellDamage = 15;
        }
    }
}
