using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class Match
    {
        private int cpuNum;
        public int CpuNum {
            get { return cpuNum; }
            set { cpuNum = value; }
        }

        private IRule rule;

        public Match(IRule rule)
        {
            this.rule = rule;
            CpuNum = 1;
        }

        public void Duel()
        {
            var hands = rule.CreateHands();

            var players = new List<IPlayer>();
            for (int i = 0; i < CpuNum; i++)
			{
			   players.Add(new CPU(i, hands));
			}
            players.Add(new Human(hands));

            var choseHands = new List<Hand>();
            foreach (var player in players)
	        {
		        choseHands.Add(player.ChooseHand());
	        }

            IJudge judge = rule.CreateJudge();
            var results = judge.Judge(choseHands);

            for (int i = 0; i < players.Count; i++)
			{
                var player = players[i].ToString();
                var hand = choseHands[i].ToString();
                var result = results[i].ToString();
                Console.WriteLine("{0}   {1}  {2}:", player, hand, result);
			}
        }
    }
}
