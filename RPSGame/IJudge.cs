using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    interface IJudge
    {
        IList<Result> Judge(IList<IPlayer> playerList);
    }
}
