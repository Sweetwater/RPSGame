using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPS.Utils;

namespace RPS {
	class Majority2Hands : IHands {
		enum HandType {
			Rock,
			Paper,
		}

		private Hand[] hands;

		public Majority2Hands() {
			var handTypeType = typeof(HandType);
			var handTypeNames = Enum.GetNames(handTypeType);
			hands = handTypeNames.Map(name => new Hand(name));
		}

		public int HandNum {
			get { return hands.Length; }
		}

		public Hand this[int index] {
			get { return hands[index]; }
		}

		public IEnumerator<Hand> GetEnumerator() {
			foreach (var hand in hands) {
				yield return hand;
			}
		}

		IEnumerator IEnumerable.GetEnumerator() {
			foreach (var hand in hands) {
				yield return hand;
			}
		}
	}
}
