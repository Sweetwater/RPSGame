using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class Result
    {
        private enum Type {
            Win,
            Lose,
            Draw,
        }

        Type type;

        public static readonly Result Win = new Result(Type.Win);
        public static readonly Result Lose = new Result(Type.Lose);
        public static readonly Result Draw = new Result(Type.Draw);

        private Result(Type type) {
            this.type = type;
        }
        public override string ToString()
        {
            return this.type.ToString();
        }

    }
}
