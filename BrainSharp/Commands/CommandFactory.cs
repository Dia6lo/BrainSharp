using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp.Commands
{
    static class CommandFactory
    {
        public static Command Get(char c)
        {
            switch (c)
            {
                case '+':
                    return new Increment();
                case '-':
                    return new Decrement();
                case '>':
                    return new IncrementPointer();
                case '<':
                    return new DecrementPointer();
                case '.':
                    return new Input();
                case ',':
                    return new Output();
                case '[':
                    return new JumpForward();
                case ']':
                    return new JumpBackward();
            }
            return null;
        }
    }
}
