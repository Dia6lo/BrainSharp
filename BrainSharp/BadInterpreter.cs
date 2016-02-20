using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp
{
	public class BadInterpreter
	{
		private const int BufferSize = 65535;
		private readonly int[] buffer = new int[BufferSize];
		private int Pointer { get; set; }
		public bool InputEnabled { get; set; }

		public BadInterpreter()
		{
			Pointer = 0;
			Array.Clear(buffer, 0, buffer.Length);
		}

		public void Interpret(string s)
		{
			var i = 0;
			var right = s.Length;
			while (i < right)
			{
				switch (s[i])
				{
					case '>':
						{
							Pointer++;
							if (Pointer >= BufferSize)
							{
								Pointer = 0;
							}
							break;
						}
					case '<':
						{
							Pointer--;
							if (Pointer < 0)
							{
								Pointer = BufferSize - 1;
							}
							break;
						}
					case '.':
						{
							Console.Write((char)buffer[Pointer]);
							break;
						}
					case '+':
						{
							buffer[Pointer]++;
							break;
						}
					case '-':
						{
							buffer[Pointer]--;
							break;
						}
					case '[':
						{
							if (buffer[Pointer] == 0)
							{
								var loop = 1;
								while (loop > 0)
								{
									i ++;
									var c = s[i];
									switch (c)
									{
										case '[':
											loop ++;
											break;
										case ']':
											loop --;
											break;
									}
								}
							}
							break;
						}
					case ']':
						{
							var loop = 1;
							while (loop > 0)
							{
								i --;
								var c = s[i];
								switch (c)
								{
									case '[':
										loop --;
										break;
									case ']':
										loop ++;
										break;
								}
							}
							i --;
							break;
						}
					case ',':
						{
							// read a key
							var key = Console.ReadKey(InputEnabled);
							buffer[Pointer] = key.KeyChar;
							break;
						}
				}
				i++;
			}
		}
	}
}
