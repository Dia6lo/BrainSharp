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
					"++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.");
			interpreter.Interpret();
			Console.ReadKey();
		}
	}
}