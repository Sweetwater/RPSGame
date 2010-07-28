using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class RPS3Judge : IJudge
    {
        private static Dictionary<Hand, Hand[]> winTable;
        
        static RPS3Judge ()
	    {
            winTable = new Dictionary<Hand,Hand[]>();
            winTable[Hand.Rock] = new Hand[]{Hand.Scissors};
            winTable[Hand.Paper] = new Hand[]{Hand.Rock};
            winTable[Hand.Scissors] = new Hand[]{Hand.Paper};
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
            if (handMap.Count == 1) {
                return CreateDrawList(choseHands.Count);
            }

            var existWinner = false;
            var results = new List<Result>();
            foreach (var hand in choseHands)
	        {
                if (losers.ContainsKey(hand)) {
                    results.Add(Result.Lose);
                }
                else {
                    results.Add(Result.Win);
                    existWinner = true;
                }
	        }
            if (existWinner == false) {
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
