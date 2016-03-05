using System;
using BrainSharp;

namespace Launcher
{
	internal static class Program
	{
		public static void Main()
		{
			var interpreter =
				new Interpreter(
					"++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.")
				{
					OutputHandler = new OutputHandler()
				};
			interpreter.Interpret();
			Console.ReadKey();
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