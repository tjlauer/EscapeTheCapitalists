// Created by: Thomas J. Lauer on April 07, 2021
// Last Modified by: Thomas J. Lauer on April 07, 2021
// Minnesota State University, Mankato
// CIS 122-02 Data Structures

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//EmailFunctions.FunctionTest ft = new EmailFunctions.FunctionTest();

namespace Assets.Scripts.CardScripts.NotInUse
{
    public class PlayerCardDeck
    {
        // Private Class Variables
        private List<CardOld> playerCardsList = new List<CardOld>();
        private int numberOfCards = 0;

        // Properties
        public List<CardOld> PlayerCardsList
        {
            get { return this.playerCardsList; }
            set { this.playerCardsList = value; }
        }

        public int NumberOfCards
        {
            get { return this.numberOfCards; }
        }



        // Methods
        public override string ToString()
        {
            string message = "";
            message = message + "numberOfCards [int]: " + this.playerCardsList.Count + "\n";
            return message;
        }
    }
}
