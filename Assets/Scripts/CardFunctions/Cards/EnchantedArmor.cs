// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions.Cards
{
    class EnchantedArmor:Minion
    {
        public EnchantedArmor()
        {
            Name = "Enchanted Armour";
            CardText = "Protect, Confusion";
            ImgPath = Resources.Load<Sprite>("CardArt/NoImage");
            CardCost = 6;
            TotalHealth = 10;
            DamageSustained = 0;
            Attack = 1;
        }
    }
}
