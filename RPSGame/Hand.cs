using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class Hand
    {
        private string type;
        public List<Hand> WinList { get; set; }

        public Hand(string type)
        {
            this.type = type;
            this.WinList = new List<Hand>();
        }

        public override string ToString()
        {
            return type;
        }
    }
}
