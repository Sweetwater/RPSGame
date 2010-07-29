using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPS.Utils;

namespace RPS {
	class ConflictJudge : IJudge {
		#region IJudge メンバ

		public IList<Result> Judge(IList<IPlayer> playerList) {
			var handGroup = playerList.GroupBy(player => player.ChoosedHand);
			if (handGroup.Count() == 1) {
				return CreateDrawList(playerList);
			}

			var loseHands = handGroup.SelectMany(hand => hand.Key.WinList);
			var results = ((List<IPlayer>)playerList).ConvertAll(player => {
				return new Result(player, loseHands.Any(hand => hand.Equals(player.ChoosedHand)) ? ResultType.Lose : ResultType.Win);
			});

			if (results.All(result => result.ResultType == ResultType.Lose)) {
				return CreateDrawList(playerList);
			}

			return results;
		}

		private IList<Result> CreateDrawList(IList<IPlayer> playerList) {
			return playerList.Map(player => new Result(player, ResultType.Draw));
		}

		#endregion
	}
}
