using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPS
{
    class RPS3Hands : IHands
    {
        private Hand[] hands = {
                Hand.Rock,
                Hand.Paper,
                Hand.Scissors};

        public int HandNum {
            get { return hands.Length; }
        }

        public Hand this[int index] {
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
