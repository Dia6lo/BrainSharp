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
		private static void PrintHelp()
		{
			Console.WriteLine("BrainFuck Interpreter");
			Console.WriteLine("Usage: {0} [Parameters]", Process.GetCurrentProcess().ProcessName);
			Console.WriteLine("Parameters:");
			Console.WriteLine("    -h: Print Help");
			Console.WriteLine("    -e: Enable Echo Input Text");
			Console.WriteLine("    -d: Disable Echo Input Text");
			Console.WriteLine("    -p: Enable Keyboard Input");
			Console.WriteLine("    FileName");
		}

		public static void Main(string[] args)
		{
			if (args.Length == 0) {
				Console.WriteLine("Try -h, Thanks!");
			}
			else {
				var bf = new BadInterpreter();
				foreach (var s in args) {
					if (s[0] == '-') // switch options
					{
						for (var i = 1; i < s.Length; i++) {
							switch (s[i]) {
								case 'h': {
										PrintHelp();
										break;
									}
								case 'd': {
										bf.InputEnabled = false;
										break;
									}
								case 'e': {
										bf.InputEnabled = true;
										break;
									}
								case 'p': {
										var src = Console.In.ReadToEnd();
										bf.Interpret(src);
										break;
									}
							}
						}
					}
					else {
						if (File.Exists(s)) {
							bf.Interpret(File.ReadAllText(s));
						}
						else {
							Console.WriteLine("File Open Error: " + s);
						}
					}
				}
			}
			Console.ReadKey();
		}
	}
}
