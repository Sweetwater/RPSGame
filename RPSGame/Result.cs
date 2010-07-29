using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS {
	class Result {
		public IPlayer Player { get; private set; }
		public ResultType ResultType { get; private set; }

		public Result(IPlayer player, ResultType resultType) {
			this.Player = player;
			this.ResultType = resultType;
		}
	}

	enum ResultType {
		Win, Lose, Draw,
	}
}
