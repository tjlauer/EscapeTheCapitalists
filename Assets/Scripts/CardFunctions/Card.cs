// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions
{
    public class Card
    {
        //variables
        private string name;
        private string cardText;
        private Sprite imgPath;
        private int cardCost;

        //properties
        public int CardCost
        {
            get { return cardCost; }
            set { cardCost = value; }
        }
        public Sprite ImgPath
        {
            get { return imgPath; }
            set { imgPath = value; }
        }
        public string CardText
        {
            get { return cardText; }
            set { cardText = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //methods

        //abstract methods

    }
}
