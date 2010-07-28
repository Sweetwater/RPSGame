using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    ///
    /// http://www.nitenichiryu.org/images/rps15.jpg
    /// 上記URLの１５ジャンケンルール
    class RPS15Rule : IRule
    {
        #region IRule メンバ

        public IHands CreateHands()
        {
            return new RPS15Hands();
        }

        public IJudge CreateJudge()
        {
            return new ConflictJudge();
        }

        #endregion
    }
}
