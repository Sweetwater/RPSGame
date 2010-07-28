using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class RPS3Rule : IRule
    {
        #region IRule メンバ

        public IHands CreateHands()
        {
            return new RPS3Hands();
        }

        public IJudge CreateJudge()
        {
            return new ConflictJudge();
        }

        #endregion
    }
}
