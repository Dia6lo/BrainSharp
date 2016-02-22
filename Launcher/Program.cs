using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using BrainSharp;

namespace Launcher
{
	class Program
	{
		public static void Main(string[] args)
		{
			var itp = new Interpreter("++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.");
			itp.Interpret();
			Console.ReadKey();
		}
	}
}
