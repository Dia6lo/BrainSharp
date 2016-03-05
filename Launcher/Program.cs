using System;
using BrainSharp;

namespace Launcher
{
	internal static class Program
	{
		public static void Main()
		{
			var interpreter =
				new Interpreter(Programs.HelloWorld)
				{
					OutputHandler = new OutputHandler(),
					InputHandler = new InputHandler()
				};
			interpreter.Interpret();
			Console.ReadKey();
		}
	}

	internal class InputHandler : IInputHandler
	{
		public char InputChar()
		{
			return Console.ReadKey().KeyChar;
		}
	}

	internal class OutputHandler : IOutputHandler
	{
		public void OutputChar(char c)
		{
			Console.Write(c);
		}

		public void RemoveChar()
		{
			throw new NotImplementedException();
		}
	}
}