using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainSharp.Commands;

namespace BrainSharp
{
    struct State
    {
        public char[] Array;
        public int Pointer;
        public string Output;
        public bool Locked;

        public State(char[] array, int pointer, string output, bool locked)
        {
            Array = array;
            Pointer = pointer;
            Output = output;
            Locked = locked;
        }
    }

    class ObsoleteProgram
    {
        private List<Command> commands = new List<Command>();
        private State currentState;

        public ObsoleteProgram(string text, int arraySize = 30000)
        {
            currentState = new State(new char[arraySize], 0, "", false);
            commands = text.Select(CommandFactory.Get).Where(c => c != null).ToList();
        }
    }
}
