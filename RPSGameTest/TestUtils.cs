using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPS;

namespace RPSGameTest {
	static class TestUtils {
		public static bool Equals<T>(this IList<T> self, IList<T> other) {
			if (self.Count != other.Count) {
				return false;
			}

			for (var i = 0; i < self.Count; i++) {
				if (!self[i].Equals(other[i])) {
					return false;
				}
			}
			return true;
		}
	}

	class StubPlayer : IPlayer {

		public Hand Hand { get; set; }

		#region IPlayer メンバ

		public Hand ChoosedHand {
			get { return this.Hand; }
		}

		public void ChooseHand() {

		}

		#endregion
	}
}
