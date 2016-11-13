using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonCode.CardGame
{
	public interface ICard
	{
        int Value { get; }
        SuitType Suit { get; }
    }

    public enum SuitType
    {
        Clubs, Spades, Hearts, Diamonds
    }
}
