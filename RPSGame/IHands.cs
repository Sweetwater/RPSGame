using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    interface IHands : IEnumerable<Hand>
    {
        int HandNum { get; }
        Hand this[int index] { get; }
    }
}
