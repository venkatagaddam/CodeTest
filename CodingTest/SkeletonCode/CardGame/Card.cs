using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
    public class Card   : ICard
    {
        public int Value { get; private set; }

        public SuitType Suit { get; private set; }

        public Card(int value, SuitType suit)
        {

            if (value > 14 || value < 1)
            {
                throw new ArgumentException("Invalid value supplied");
            }

            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            string output = "";
            if (Value > 10)
            {
                switch (Value)
                {
                    case 11:
                        output += "Jack";
                        break;
                    case 12:
                        output += "Queen";
                        break;
                    case 13:
                        output += "King";
                        break;
                    case 14:
                        output += "Ace";
                        break;
                }
            }
            else
            {
                output += Value;
            }
            output += " of " + System.Enum.GetName(typeof(SuitType), Suit);
            return output;
        }
    }
}
