using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	class Majority2Rule : IRule {
		#region IRule メンバ

		public IHands CreateHands() {
			return new Majority2Hands();
		}

		public IJudge CreateJudge() {
			return new MajorityDecisionJudge();
		}

		#endregion
	}
}
