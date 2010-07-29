using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;
using RPS.Utils;

namespace RPSGameTest
{
    
    
    /// <summary>
    ///MajorityDecisionJudgeTest のテスト クラスです。すべての
    ///MajorityDecisionJudgeTest 単体テストをここに含めます
    ///</summary>
	[TestClass()]
	public class MajorityDecisionJudgeTest {

		private IJudge target = new MajorityDecisionJudge();

		[TestMethod()]
		[ExpectedException(typeof(ArgumentNullException))]
		public void MajorityDecisition_Error_ListIsNull() {
			// Arrange
			IList<IPlayer> playerList = null;

			// Act
			var result = target.Judge(playerList);
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentException))]
		public void MajorityDecisition_Error_ListIsEmpty() {
			// Arrange
			IList<IPlayer> playerList = new List<IPlayer>();

			// Act
			var result = target.Judge(playerList);
		}

		/// <summary>
		///Judge のテスト
		///</summary>
		[TestMethod()]
		public void MajorityDecisition_Draw_Same_1() {
			// Arrange
			IList<IPlayer> playerList = new List<IPlayer> {
				new StubPlayer { Hand = new Hand("Rock") },
			};

			// Act
			var result =  target.Judge(playerList).Map(r => r.ResultType);
			var actual = new List<ResultType> {
				ResultType.Draw,
			};

			// Assert
			Assert.IsTrue(actual.Equals<ResultType>(result));
		}

		[TestMethod()]
		public void MajorityDecisition_Draw_Same_2() {
			// Arrange
			IList<IPlayer> playerList = new List<IPlayer> {
				new StubPlayer { Hand = new Hand("Rock") },
				new StubPlayer { Hand = new Hand("Rock") },
			};

			// Act
			var result = target.Judge(playerList).Map(r => r.ResultType);
			var actual = new List<ResultType> {
				ResultType.Draw,
				ResultType.Draw,
			};

			// Assert
			Assert.IsTrue(actual.Equals<ResultType>(result));
		}

		[TestMethod()]
		public void MajorityDecisition_Draw_Equals() {
			// Arrange
			var rock = new Hand("Rock");
			var paper = new Hand("Paper");
			IList<IPlayer> playerList = new List<IPlayer> {
				new StubPlayer { Hand = rock },
				new StubPlayer { Hand = paper },
			};

			// Act
			var result = target.Judge(playerList).Map(r => r.ResultType);
			var actual = new List<ResultType> {
				ResultType.Draw,
				ResultType.Draw,
			};

			// Assert
			Assert.IsTrue(actual.Equals<ResultType>(result));
		}

		[TestMethod()]
		public void MajorityDecisition_Win() {
			// Arrange
			var rock = new Hand("Rock");
			var paper = new Hand("Paper");

			IList<IPlayer> playerList = new List<IPlayer> {
				new StubPlayer { Hand = rock },
				new StubPlayer { Hand = rock },
				new StubPlayer { Hand = paper },
			};

			// Act
			var result = target.Judge(playerList).Map(r => r.ResultType);
			var actual = new List<ResultType> {
				ResultType.Win,
				ResultType.Win,
				ResultType.Lose,
			};

			Console.WriteLine(string.Join(",", result.Map(item => item.ToString()).ToArray()));

			// Assert
			Assert.IsTrue(actual.Equals<ResultType>(result));
		}
	}
}
