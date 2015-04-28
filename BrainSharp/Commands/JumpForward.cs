﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class JumpForward: Command
    {
        public override State Execute(State state)
        {
            if (state.Locked)
                return state;
            return state.Array[state.Pointer] == 0 ? new State(state.Array, state.Pointer, state.Output, true) : state;
        }
    }
}