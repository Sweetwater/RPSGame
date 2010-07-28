using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class RPS15Judge : IJudge
    {
        private static Hand[] winOrder = {
            Hand.Gun,
            Hand.Rock,
            Hand.Fire,
            Hand.Scissors,
            Hand.Snake,
            Hand.Human,
            Hand.Tree,
            Hand.Wolf,
            Hand.Sponge,
            Hand.Paper,
            Hand.Air,
            Hand.Water,
            Hand.Dragon,
            Hand.Devil,
            Hand.Lightning,
        };
        private static Dictionary<Hand, Hand[]> winTable;

        static RPS15Judge()
        {
            winTable = new Dictionary<Hand, Hand[]>();

            var winHandNum = winOrder.Length / 2;
            for (int i = 0; i < winOrder.Length; i++)
            {
                var hand = winOrder[i];
                var index = i + 1;
                var losers = new Hand[winHandNum];
                for (int j = 0; j < winHandNum; j++)
                {
                    if (index > winOrder.Length - 1)
                    {
                        index -= winOrder.Length;
                    }
                    losers[j] = winOrder[index];
                    index++;
                }
                winTable[hand] = losers;
            }
        }

        public IList<Result> Judge(IList<Hand> choseHands)
        {
            var handMap = new Dictionary<Hand, bool>();
            var losers = new Dictionary<Hand, bool>();
            foreach (var hand in choseHands)
            {
                if (handMap.ContainsKey(hand)) continue;

                handMap[hand] = true;
                foreach (var loser in winTable[hand])
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
    }
}
