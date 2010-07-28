using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class CPU : IPlayer
    {
        private static Random random = new Random();

        private int number;
        private IHands hands;

        public CPU(int number, IHands hands)
        {
            this.number = number;
            this.hands = hands;
        }

        public Hand ChooseHand()
        {
            var index = random.Next(hands.HandNum);
            var hand = hands[index];
            return hand;
        }

        public override string ToString() 
        {
            return "cpu" + number;
        }
    }
}
