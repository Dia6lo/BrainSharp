using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class IncrementPointer: Command
    {
        public override State Execute(State state)
        {
            return state.Locked ? state : new State(state.Array, state.Pointer++, state.Output, false);
        }
    }
}
