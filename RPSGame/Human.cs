using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	class Human : IPlayer {
		public Hand ChoosedHand { get; private set; }

		private IHands hands;

		public Human(IHands hands) {
			this.hands = hands;
		}

		public void ChooseHand() {
			var textSelector = new TextSelector() {
				Caption = string.Join(",", hands.ToList().ConvertAll(hand => hand.ToString()).ToArray()),
				Items = hands.ToList().ConvertAll(hand => hand.ToString())
			};
			var result = textSelector.DoSelect();
			var number = result.Number;
			this.ChoosedHand = hands[number];
		}

		public override string ToString() {
			return "player";
		}
	}
}
