// written Dustin Frandle
// 4/24/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardFunctions
{
    class CardHelper
    {
        //variables
        private readonly Minion thisMinion;
        private readonly Spell thisSpell;
        private readonly Monster thisMonster;
        private readonly Card thisCard;
        private List<Minion> effectedMinions;

        //properties
        public List<Minion> EffectedMinions
        {
            get { return effectedMinions; }
            set { effectedMinions = value; }
        }
        public Card ThisCard
        {
            get { return thisCard; }
        }
        public Monster ThisMonster
        {
            get { return thisMonster; }
        }
        public Spell ThisSpell
        {
            get { return thisSpell; }
        }
        public Minion ThisMinion
        {
            get { return thisMinion; }
        }

        //Constructors
        public CardHelper(Monster thisMonster)
        {
            this.thisMonster = thisMonster;
        }
        public CardHelper(Minion thisMinion)
        {
            this.thisMinion = thisMinion;
        }
        public CardHelper(Spell thisSpell)
        {
            this.thisSpell = thisSpell;
        }
        public CardHelper(Card thisCard)
        {
            this.thisCard = thisCard;
            Debug.Log("Card Helper created with 'Card' object - use more specific object if posible");
        }//only use if Minion, Spell, or Monster wont work.
        public CardHelper(Monster thisMonster, List<Minion> list)
        {
            this.thisMonster = thisMonster;
            EffectedMinions = list;
        }
        public CardHelper(Minion thisMinion, List<Minion> list)
        {
            this.thisMinion = thisMinion;
            EffectedMinions = list;
        }
        public CardHelper(Spell thisSpell, List<Minion> list)
        {
            this.thisSpell = thisSpell;
            EffectedMinions = list;
        }
        public CardHelper(Card thisCard, List<Minion> list)
        {
            this.thisCard = thisCard;
            EffectedMinions = list;
            Debug.Log("Card Helper created with 'Card' object - use more specific object if posible");
        }//only use if Minion, Spell, or Monster wont work.


        //Methods


    }
}
