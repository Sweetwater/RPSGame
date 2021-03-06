﻿using System;
using System.Collections;
using System.Collections.Generic;
using RPS.Utils;

namespace RPS {
	class RPS15Hands : IHands {
		enum HandType {
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
		};

		private Hand[] hands;

		public RPS15Hands() {
			var handTypeType = typeof(HandType);
			var handTypeNames = Enum.GetNames(handTypeType);
			hands = handTypeNames.Map(name => new Hand(name));

			var itemCount = Enum.GetValues(handTypeType).Length;
			for (int i = 0; i < itemCount; i++) {
				int numberOfWin = itemCount / 2;
				int index = (i + 1) % itemCount;
				for (int j = 0; j < numberOfWin; ++j) {
					hands[i].WinList.Add(hands[index]);
					index = (index + 1) % itemCount;
				}
			}
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
