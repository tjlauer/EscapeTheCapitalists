// Created by: Thomas J. Lauer on April 07, 2021
// Last Modified by: Thomas J. Lauer on April 07, 2021
// Minnesota State University, Mankato
// CIS 122-02 Data Structures

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardScripts.NotInUse
{
    public class InitiateCards
    {
        // Private Class Variables
        private List<CardOld> cardsList = new List<CardOld>();

        private int numberOfCards = 0;

        private string minionCardsPath = "/Data/Minions.csv";
        private string spellCardsPath = "/Data/Spells.csv";



        // Properties
        public string MinionCardsPath
        {
            get { return this.minionCardsPath; }
            set { this.minionCardsPath = value; UpdateCardList(); }
        }

        public string SpellCardsPath
        {
            get { return this.spellCardsPath; }
            set { this.spellCardsPath = value; UpdateCardList(); }
        }

        public List<CardOld> CardsList
        {
            get { return this.cardsList; }
            set { this.cardsList = value; }
        }



        // Methods

        // Read all card data from the CSV files and update the card list.
        public void UpdateCardList()
        {
            CardsList = new List<CardOld>();

            // Define paths to CSV files
            string minionCardsPath_full = Application.dataPath + MinionCardsPath;
            string spellCardsPath_full = Application.dataPath + SpellCardsPath;

            // Initiate the File Gateway for accessing the CSV files
            FileGateway aFileGateway = new FileGateway();

            // Create sub-lists for each of the different card types
            List<CardOld> CardsList_minions = new List<CardOld>();
            List<CardOld> CardsList_spells = new List<CardOld>();

            // Populate card sub-lists with their respective card types
            CardsList_minions = aFileGateway.GetCards(minionCardsPath_full);
            CardsList_spells = aFileGateway.GetCards(spellCardsPath_full);

            // Add contents of all sub-lists to the main card list
            foreach (CardOld currentMinionCard in CardsList_minions) { CardsList.Add(currentMinionCard); numberOfCards++; }
            foreach (CardOld currentSpellCard in CardsList_spells) { CardsList.Add(currentSpellCard); numberOfCards++; }
        }
    }
}
