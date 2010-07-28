using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class RPS3Rule : IRule
    {
        public IHands CreateHands()
        {
            return new RPS3Hands();
        }

        public IJudge CreateJudge()
        {
            return new RPS3Judge();
        }
    }
}
