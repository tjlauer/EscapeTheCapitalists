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
    public class CardsOld
    {
        private int numberOfCards = 0;
        private List<CardOld> cardsList = new List<CardOld>();

        public List<CardOld> CardsList
        {
            get
            {
                return this.cardsList;
            }
        }

        public void UpdateCardList(string minionCardsPath_full, string spellCardsPath_full)
        {
            numberOfCards = 0;

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

        public List<CardOld> GetCardList()
        {
            //writeCardList2DebugLog(5);
            return CardsList;
        }

        public string writeCardList2DebugLog(int level)
        {
            string debugMessage = "";
            if (level == 1)
            {
                // Print card info to debugging console [CardId]
                foreach (CardOld currentCard in CardsList) { debugMessage += currentCard.ToString_CardId() + "--------------------------------------------------\n"; }
            }
            else if (level == 2)
            {
                // Print card info to debugging console [CardId, Name]
                foreach (CardOld currentCard in CardsList) { debugMessage += currentCard.ToString_Name() + "--------------------------------------------------\n"; }
            }
            else if (level == 3)
            {
                // Print card info to debugging console [CardId, Creator]
                foreach (CardOld currentCard in CardsList) { debugMessage += currentCard.ToString_Creator() + "--------------------------------------------------\n"; }
            }
            else if (level == 4)
            {
                // Print card info to debugging console [CardId, Creator, Name, Cost]
                foreach (CardOld currentCard in CardsList) { debugMessage += currentCard.ToString_Short() + "--------------------------------------------------\n"; }
            }
            else if (level == 5)
            {
                // Print card info to debugging console [ALL VARIABLES]
                foreach (CardOld currentCard in CardsList) { debugMessage += currentCard.ToString() + "--------------------------------------------------\n"; }
            }

            if (debugMessage == "")
            {
                return "Invalid value for 'int level'";
            }
            else
            {
                return debugMessage;
            }
        }
    }
}
