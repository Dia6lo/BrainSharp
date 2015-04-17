using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainSharp.Commands;

namespace BrainSharp
{
    class Program
    {
        private List<Command> commands = new List<Command>();
        private char[] array;
        private string output;

        public Program(string text, int arraySize = 30000)
        {
            array = new char[arraySize];
            commands = text.Select(CommandFactory.Get).Where(c => c != null).ToList();
        }
    }
}
