using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPS
{
    class RPS15Hands : IHands
    {
        private Hand[] hands = {
            Hand.Gun,
            Hand.Rock,
            Hand.Fire,
            Hand.Scissors,
            Hand.Snake,
            Hand.Human,
            Hand.Tree,
            Hand.Wolf,
            Hand.Sponge,
            Hand.Paper,
            Hand.Air,
            Hand.Water,
            Hand.Dragon,
            Hand.Devil,
            Hand.Lightning,
        };

        public int HandNum
        {
            get { return hands.Length; }
        }

        public Hand this[int index]
        {
            get { return hands[index]; }
        }

        public IEnumerator<Hand> GetEnumerator()
        {
            foreach (var hand in hands)
            {
                yield return hand;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var hand in hands)
            {
                yield return hand;
            }
        }
    }
}
