using System;

namespace BrainSharp.Commands
{
	internal class Input : ICommand
	{
		public void Execute(State state)
		{
			state.Array[state.Pointer] = Console.ReadKey().KeyChar;
		}
	}
}