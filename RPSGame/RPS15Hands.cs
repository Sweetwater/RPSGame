using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPS
{
    class RPS15Hands : IHands
    {
        enum HandType
        {
            Gun,
            Rock,
            Fire,
            Scissors,
            Snake,
            Human,
            Tree,
            Wolf,
            Sponge,
            Paper,
            Air,
            Water,
            Dragon,
            Devil,
            Lightning,
            NumberOfTypes
        };

        private Hand[] hands = new Hand[15];
        
        public RPS15Hands()
        {
            hands[(int)HandType.Gun] = new Hand(HandType.Gun.ToString());
            hands[(int)HandType.Rock] = new Hand(HandType.Rock.ToString());
            hands[(int)HandType.Fire] = new Hand(HandType.Fire.ToString());
            hands[(int)HandType.Scissors] = new Hand(HandType.Scissors.ToString());
            hands[(int)HandType.Snake] = new Hand(HandType.Snake.ToString());
            hands[(int)HandType.Human] = new Hand(HandType.Human.ToString());
            hands[(int)HandType.Tree] = new Hand(HandType.Tree.ToString());
            hands[(int)HandType.Wolf] = new Hand(HandType.Wolf.ToString());
            hands[(int)HandType.Sponge] = new Hand(HandType.Sponge.ToString());
            hands[(int)HandType.Paper] = new Hand(HandType.Paper.ToString());
            hands[(int)HandType.Air] = new Hand(HandType.Air.ToString());
            hands[(int)HandType.Water] = new Hand(HandType.Water.ToString());
            hands[(int)HandType.Dragon] = new Hand(HandType.Dragon.ToString());
            hands[(int)HandType.Devil] = new Hand(HandType.Devil.ToString());
            hands[(int)HandType.Lightning] = new Hand(HandType.Lightning.ToString());

            for (int i = 0, num = (int)HandType.NumberOfTypes; i < num; ++i)
            {
                int number_of_win = num / 2;
                int index = (i + 1) % num;
                for (int j = 0; j < number_of_win; ++j)
                {
                    hands[i].WinList.Add(hands[index]);
                    index = (index + 1) % num;
                }
            }
        }

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
