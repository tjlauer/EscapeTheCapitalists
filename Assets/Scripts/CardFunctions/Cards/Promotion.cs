// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class Promotion:Spell
    {
        public Promotion()
        {
            Name = "Promotion";
            CardText = "Give a minion +2/2 and Protect.";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 0;
            SpellDamage = 0;
        }
    }
}
