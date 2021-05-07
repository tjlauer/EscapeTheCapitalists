// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class LightHeal:Spell
    {
        public LightHeal()
        {
            Name = "Light Heal";
            CardText = "Restores 4 health to the selected character.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 2;
            SpellDamage = 4; //how much its healed actualy
        }
    }
}
