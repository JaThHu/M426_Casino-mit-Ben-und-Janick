using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB426_FinalGame
{
    using System;

    public class Symbol
    {
        public string Name { get; }
        public int Value { get; }
        public ConsoleColor Color { get; }

        public Symbol(string name, int value, ConsoleColor color)
        {
            Name = name;
            Value = value;
            Color = color;
        }
    }
}


