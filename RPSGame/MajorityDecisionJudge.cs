using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPS.Utils;

namespace RPS {
	class MajorityDecisionJudge : IJudge {

		#region IJudge メンバ

		public IList<Result> Judge(IList<IPlayer> playerList) {
			if (playerList == null) {
				throw new ArgumentNullException("player is missing");
			}

			if (playerList.Count < 1) {
				throw new ArgumentException("MajorityDecision need one person or more.");
			}

			var handLookup = playerList.ToLookup(player => player.ChoosedHand);
			if (handLookup.Count == 1) {
				return playerList.Map(player => new Result(player, ResultType.Draw));
			}
			var maxCount = handLookup.Max(hand => handLookup[hand.Key].Count());
			if (handLookup.Count(group => group.Count() == maxCount) > 1) {
				return playerList.Map(player => new Result(player, ResultType.Draw));
			}
			var winHand = handLookup.First(group => group.Count() == maxCount).Key;
			return playerList.Map(player => new Result(player, player.ChoosedHand.Equals(winHand) ? ResultType.Win : ResultType.Lose));
		}

		#endregion
	}
}
