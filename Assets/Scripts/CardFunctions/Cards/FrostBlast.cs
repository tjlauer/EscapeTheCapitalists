// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class FrostBlast:Spell
    {
        public FrostBlast()
        {
            Name = "Frost Blast";
            CardText = "Apply Freezing to a monster.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 0;
            SpellDamage = 0;
            
        }
    }
}
