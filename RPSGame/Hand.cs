using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS
{
    class Hand
    {
        private string type;
        public static readonly Hand Rock = new Hand("Rock");
        public static readonly Hand Paper = new Hand("Paper");
        public static readonly Hand Scissors = new Hand("Scissors");

        public static readonly Hand Gun = new Hand("Gun");
        public static readonly Hand Fire = new Hand("Fire");
        public static readonly Hand Snake = new Hand("Snake");
        public static readonly Hand Human = new Hand("Human");
        public static readonly Hand Tree = new Hand("Tree");
        public static readonly Hand Wolf = new Hand("Wolf");
        public static readonly Hand Sponge = new Hand("Sponge");
        public static readonly Hand Air = new Hand("Air");
        public static readonly Hand Water = new Hand("Water");
        public static readonly Hand Dragon = new Hand("Dragon");
        public static readonly Hand Devil = new Hand("Devil");
        public static readonly Hand Lightning = new Hand("Lightning");

        private Hand(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return type;
        }
    }
}
