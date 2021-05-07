// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Duplicate:Spell
    {
        public Duplicate()
        {
            Name = "Duplicate";
            CardText = "Duplicates any minion or monster in play for half its cost";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 0;//varries
            SpellDamage = 0;
        }
    }
}
