using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class Increment: Command
    {
        public override State Execute(State state)
        {
            if (state.Locked)
                return state;
            var a = state.Array;
            a[state.Pointer]++;
            return new State(a, state.Pointer, state.Output, false);
        }
    }
}
