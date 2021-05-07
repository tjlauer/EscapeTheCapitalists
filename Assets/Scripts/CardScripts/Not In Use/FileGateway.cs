// Created by: Thomas J. Lauer on April 07, 2021
// Last Modified by: Thomas J. Lauer on April 07, 2021
// Minnesota State University, Mankato
// CIS 122-02 Data Structures

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Assets.Scripts.CardScripts.NotInUse
{
    public class FileGateway
    {
        private string[] allLines;


        public List<CardOld> GetCards(string aPath)
        {
            List<CardOld> aListOfCards = new List<CardOld>();
            int index = 1;
    
            // Now read all lines as an array of strings
            allLines = File.ReadAllLines(aPath);
            string[] oneLine = null;
            CardOld aCard;

            // Loop through all of the lines and add them to the queue
            while (index < allLines.Length)
            {
                int colNum = 0;
                oneLine = allLines[index].Split(',');
                aCard = new CardOld();
                aCard.CardId = oneLine[colNum]; colNum++;
                aCard.Creator = oneLine[colNum]; colNum++;
                aCard.Name = oneLine[colNum]; colNum++;
                aCard.Type = oneLine[colNum]; colNum++;
                aCard.Rarity = oneLine[colNum]; colNum++;
                aCard.Cost = Convert.ToInt32(oneLine[colNum]); colNum++;
                aCard.Health = Convert.ToInt32(oneLine[colNum]); colNum++;
                aCard.Attack = Convert.ToInt32(oneLine[colNum]); colNum++;
                aCard.EffectName = oneLine[colNum]; colNum++;
                aCard.EffectDesc = oneLine[colNum]; colNum++;
                aCard.EffectCost = Convert.ToInt32(oneLine[colNum]); colNum++;
                aCard.EffectTarget = oneLine[colNum]; colNum++;
                aCard.EffectTargetCount = Convert.ToInt32(oneLine[colNum]); colNum++;
                aCard.EffectMagnitude = Convert.ToInt32(oneLine[colNum]);

                // add student to the Queue
                aListOfCards.Add(aCard);
                index = index + 1;
            }

            // Return the final queue
            return aListOfCards;

        }
    }
}
