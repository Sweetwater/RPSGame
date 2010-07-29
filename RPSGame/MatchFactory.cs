using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class MatchFactory
    {
        public delegate IRule CreateRule();

        public static IDictionary<string, CreateRule> factoryTable;

        public static IList<string> RuleLists
        {
            get { return factoryTable.Keys.ToList<string>(); }
        }

        static MatchFactory() {
            factoryTable = new Dictionary<string, CreateRule>{
                {"RPS 3", CreateRPS3},
                {"RPS 15", CreateRPS15},
				{"Majority2", CreateMajority2},
            };
        }

        public static Match Create(string ruleName, int cpuNum)
        {
            var rule = factoryTable[ruleName]();
            return new Match(rule) { CpuNum = cpuNum };
        }

        private static RPS3Rule CreateRPS3()
        {
            return new RPS3Rule();
        }

        private static RPS15Rule CreateRPS15()
        {
            return new RPS15Rule();
        }

		private static Majority2Rule CreateMajority2() {
			return new Majority2Rule();
		}
    }
}
