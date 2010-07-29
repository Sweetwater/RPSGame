using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	class CPU : IPlayer {
		public Hand ChoosedHand { get; private set; }

		private static Random random = new Random();

		private int number;
		private IHands hands;

		public CPU(int number, IHands hands) {
			this.number = number;
			this.hands = hands;
		}

		public void ChooseHand() {
			var index = random.Next(hands.HandNum);
			var hand = hands[index];
			this.ChoosedHand = hand;
		}

		public override string ToString() {
			return "cpu" + number.ToString();
		}
	}
}
