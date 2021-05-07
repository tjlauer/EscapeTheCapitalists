// Created by: Thomas J. Lauer on April 07, 2021
// Last Modified by: Thomas J. Lauer on April 07, 2021
// Minnesota State University, Mankato
// CIS 122-02 Data Structures

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.CardScripts.NotInUse
{
    public class CardOld
    {
        // Private Class Variables
        private string cardId = "n/a";
        private string creator = "n/a";
        private string name = "n/a";
        private string type = "n/a";
        private string rarity = "n/a";
        private int cost = -1;
        private int health = -1;
        private int attack = -1;
        private string effectName = "n/a";
        private string effectDesc = "n/a";
        private int effectCost = -1;
        private string effectTarget = "n/a";
        private int effectTargetCount = -1;
        private int effectMagnitude = -1;

        // Properties
        public string CardId
        {
            get { return this.cardId; }
            set { this.cardId = value; }
        }
        public string Creator
        {
            get { return this.creator; }
            set { this.creator = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Rarity
        {
            get { return this.rarity; }
            set { this.rarity = value; }
        }
        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }
        public string EffectName
        {
            get { return this.effectName; }
            set { this.effectName = value; }
        }
        public string EffectDesc
        {
            get { return this.effectDesc; }
            set { this.effectDesc = value; }
        }
        public int EffectCost
        {
            get { return this.effectCost; }
            set { this.effectCost = value; }
        }
        public string EffectTarget
        {
            get { return this.effectTarget; }
            set { this.effectTarget = value; }
        }
        public int EffectTargetCount
        {
            get { return this.effectTargetCount; }
            set { this.effectTargetCount = value; }
        }
        public int EffectMagnitude
        {
            get { return this.effectMagnitude; }
            set { this.effectMagnitude = value; }
        }

        // Methods
        public string ToString_CardId()
        {
            string message = "";
            message = message + "CardId [string]: " + this.CardId + "\n";
            return message;
        }
        public string ToString_Name()
        {
            string message = "";
            message = message + "CardId [string]: " + this.CardId + "\n";
            message = message + "Name [string]: " + this.Name + "\n";
            return message;
        }
        public string ToString_Creator()
        {
            string message = "";
            message = message + "CardId [string]: " + this.CardId + "\n";
            message = message + "Creator [string]: " + this.Creator + "\n";
            return message;
        }
        public string ToString_Short()
        {
            string message = "";
            message = message + "CardId [string]: " + this.CardId + "\n";
            message = message + "Creator [string]: " + this.Creator + "\n";
            message = message + "Name [string]: " + this.Name + "\n";
            message = message + "Cost [int]: " + this.Cost + "\n";
            return message;
        }
        public override string ToString()
        {
            string message = "";
            message = message + "CardId [string]: " + this.CardId + "\n";
            message = message + "Creator [string]: " + this.Creator + "\n";
            message = message + "Name [string]: " + this.Name + "\n";
            message = message + "Type [string]: " + this.Type + "\n";
            message = message + "Rarity [string]: " + this.Rarity + "\n";
            message = message + "Cost [int]: " + this.Cost + "\n";
            message = message + "Health [int]: " + this.Health + "\n";
            message = message + "Attack [int]: " + this.Attack + "\n";
            message = message + "EffectName [string]: " + this.EffectName + "\n";
            message = message + "EffectDesc [string]: " + this.EffectDesc + "\n";
            message = message + "EffectCost [int]: " + this.EffectCost + "\n";
            message = message + "EffectTarget [string]: " + this.EffectTarget + "\n";
            message = message + "EffectTargetCount [int]: " + this.EffectTargetCount + "\n";
            message = message + "EffectMagnitude [int]: " + this.EffectMagnitude + "\n";
            return message;
        }
    }
}
