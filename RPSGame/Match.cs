using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	class Match {
		private int cpuNum;
		public int CpuNum {
			get { return cpuNum; }
			set { cpuNum = value; }
		}

		private IRule rule;

		public Match(IRule rule) {
			this.rule = rule;
			this.cpuNum = 1;
		}

		public void Duel() {
			var hands = rule.CreateHands();

			IList<IPlayer> players = new List<IPlayer>();
			for (var i = 0; i < CpuNum; i++) {
				players.Add(new CPU(i, hands));
			}
			players.Add(new Human(hands));

			foreach (var player in players) {
				player.ChooseHand();
			}

			IJudge judgment = rule.CreateJudge();
			var results = judgment.Judge(players);

			foreach (var result in results) {
				var playerName = result.Player.ToString();
				var handName = result.Player.ChoosedHand.ToString();
				var message = result.ResultType.ToString();
				Console.WriteLine("{0}\t{1}  {2}:", playerName, handName, message);
			}
		}
	}
}
