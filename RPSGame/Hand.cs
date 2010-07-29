using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	public class Hand : IEquatable<Hand>, IComparable<Hand> {
		private string handName;
		public IList<Hand> WinList { get; set; }

		public Hand(string type) {
			this.handName = type;
			this.WinList = new List<Hand>();
		}

		public override string ToString() {
			return handName;
		}

		public override int GetHashCode() {
			return this.handName.GetHashCode();
		}

		public override bool Equals(object obj) {
			if (obj is Hand == false) {
				return false;
			}
			return this.Equals((Hand)obj);
		}

		#region IEquatable<Hand> メンバ

		public bool Equals(Hand other) {
			return this.handName == other.handName;
		}

		#endregion

		#region IComparable<Hand> メンバ

		public int CompareTo(Hand other) {
			if (this.Equals(other)) {
				return 0;
			} else if (this.WinList.Any(hand => hand.Equals(other))) {
				return 1;
			} else {
				return -1;
			}
		}

		#endregion
	}
}
