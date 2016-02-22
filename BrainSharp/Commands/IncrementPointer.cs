using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class IncrementPointer: ICommand
    {
        public State Execute(State state)
        {
	        state.Pointer++;
	        return state;
        }
    }
}
