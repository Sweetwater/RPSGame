using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class Human : IPlayer
    {
        private IHands hands;

        public Human(IHands hands)
        {
            this.hands = hands;
        }
        
        public Hand ChooseHand()
        {
            var chosser = new TextSelector()
            {
                Caption = string.Join(",", hands),
                Items = hands.ToList().ConvertAll(hand=>hand.ToString())
            };
            chosser.Select();
            var number = chosser.SelectedNumber;
            return hands[number];
        }

        public override string ToString()
        {
            return "player";
        }
    }
}
