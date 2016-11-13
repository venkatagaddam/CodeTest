using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
    class PackOfCards : IPackOfCards
    {
        const int TotalCardsInPack = 52;

        List<ICard> packOfCards;

        public PackOfCards()
        {
            packOfCards = new List<ICard>();

            foreach (SuitType s in Enum.GetValues(typeof(SuitType)))
            {
                for (var i = 2; i <= 14; i++)
                {
                    packOfCards.Add(new Card(i, s));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < packOfCards.Count ; i++)
            {
                Random rnd = new Random();

                int rndIndex = rnd.Next(0, packOfCards.Count - 1);

                ICard tempCard = packOfCards[rndIndex];

                packOfCards[rndIndex] = packOfCards[i];

                packOfCards[i] = tempCard;
            }
        }

        public ICard TakeCardFromTopOfPack() {

            ICard card = packOfCards[0];

            packOfCards.RemoveAt(0);

            return card;

        }
        
        public IEnumerator<ICard> GetEnumerator()
        {
            return packOfCards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return packOfCards.GetEnumerator();
        }

        public int Count
        {
            get { return packOfCards.Count; }
        }

    }
}
