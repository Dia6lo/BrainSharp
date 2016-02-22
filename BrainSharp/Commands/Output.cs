using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class Output: ICommand
    {
        public State Execute(State state)
        {
            state.Output += state.Array[state.Pointer];
            return state;
        }
    }
}
