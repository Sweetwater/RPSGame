using RPS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RPSGameTest
{
    
    
    /// <summary>
    ///ConflictJudgeTest のテスト クラスです。すべての
    ///ConflictJudgeTest 単体テストをここに含めます
    ///</summary>
	[TestClass()]
	public class ConflictJudgeTest {

		private IJudge target = new ConflictJudge();

		#region 追加のテスト属性
		// 
		//テストを作成するときに、次の追加属性を使用することができます:
		//
		//クラスの最初のテストを実行する前にコードを実行するには、ClassInitialize を使用
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//クラスのすべてのテストを実行した後にコードを実行するには、ClassCleanup を使用
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//各テストを実行する前にコードを実行するには、TestInitialize を使用
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//各テストを実行した後にコードを実行するには、TestCleanup を使用
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		/// <summary>
		///Judge のテスト
		///</summary>
		[TestMethod()]
		public void JudgeTest() {
			ConflictJudge target = new ConflictJudge(); // TODO: 適切な値に初期化してください
			IList<IPlayer> playerList = null; // TODO: 適切な値に初期化してください
			IList<Result> expected = null; // TODO: 適切な値に初期化してください
			IList<Result> actual;
			actual = target.Judge(playerList);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("このテストメソッドの正確性を確認します。");
		}
	}
}
