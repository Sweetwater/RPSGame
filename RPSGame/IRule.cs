﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    interface IRule
    {
        IHands CreateHands();

        IJudge CreateJudge();
    }
}
