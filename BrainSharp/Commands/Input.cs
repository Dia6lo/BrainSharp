using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    class Input: ICommand
    {
        public State Execute(State state)
        {
	        state.Array[state.Pointer] = Console.ReadKey().KeyChar;
	        return state;
        }
    }
}
