using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPS
{
    class RPS3Hands : IHands
    {
        enum HandType
        {
            Rock,
            Paper,
            Scissors,
            NumberOfTypes
        };

        private Hand[] hands = new Hand[(int)HandType.NumberOfTypes];

        public RPS3Hands()
        {
            hands[(int)HandType.Rock] = new Hand(HandType.Rock.ToString());
            hands[(int)HandType.Paper] = new Hand(HandType.Paper.ToString());
            hands[(int)HandType.Scissors] = new Hand(HandType.Scissors.ToString());

            hands[(int)HandType.Rock].WinList.Add(hands[(int)HandType.Scissors]);
            hands[(int)HandType.Paper].WinList.Add(hands[(int)HandType.Rock]);
            hands[(int)HandType.Scissors].WinList.Add(hands[(int)HandType.Paper]);
        }

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
