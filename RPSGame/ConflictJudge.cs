using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class ConflictJudge : IJudge
    {
        #region IJudge メンバ

        public IList<Result> Judge(IList<Hand> choseHands)
        {
            var handMap = new Dictionary<Hand, bool>();
            var losers = new Dictionary<Hand, bool>();
            foreach (var hand in choseHands)
            {
                if (handMap.ContainsKey(hand)) continue;

                handMap[hand] = true;
                foreach (var loser in hand.WinList)
                {
                    losers[loser] = true;
                }
            }
            if (handMap.Count == 1)
            {
                return CreateDrawList(choseHands.Count);
            }

            var existWinner = false;
            var results = new List<Result>();
            foreach (var hand in choseHands)
            {
                if (losers.ContainsKey(hand))
                {
                    results.Add(Result.Lose);
                }
                else
                {
                    results.Add(Result.Win);
                    existWinner = true;
                }
            }
            if (existWinner == false)
            {
                return CreateDrawList(choseHands.Count);
            }

            return results;
        }

        private IList<Result> CreateDrawList(int num)
        {
            var list = new List<Result>();
            for (int i = 0; i < num; i++)
            {
                list.Add(Result.Draw);
            }
            return list;
        }

        #endregion
    }
}
