// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions
{
    public class Minion:Card
    {
        //variables
        private int totalHealth;
        private int damageSustained;
        private int attack;

        //properties
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int DamageSustained
        {
            get { return damageSustained; }
            set { damageSustained = value; }
        }
        public int TotalHealth
        {
            get { return totalHealth; }
            set { totalHealth = value; }
        }

        //methods

        //abstract methods
    }
}
