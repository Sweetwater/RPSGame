using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	interface IPlayer {
		Hand ChoosedHand { get; }
		void ChooseHand();
		string ToString();
	}
}
