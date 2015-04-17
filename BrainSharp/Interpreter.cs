using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp
{
    public static class Interpreter
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: {0} <path to a source file>", Process.GetCurrentProcess().ProcessName);
                Console.ReadKey();
                return;
            }
            var filePath = args[0];
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No source file at " + filePath);
                Console.ReadKey();
                return;
            }
            var programText = File.ReadAllText(filePath);
            var program = new Program(programText);
            Console.ReadKey();
        }
    }
}
