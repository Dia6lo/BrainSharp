﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class Input: Command
    {
        public override State Execute(State state)
        {
            if (state.Locked)
                return state;
            var c = Console.ReadKey().KeyChar;
            var a = state.Array;
            a[state.Pointer] = c;
            return new State(a, state.Pointer, state.Output, false);
        }
    }
}
