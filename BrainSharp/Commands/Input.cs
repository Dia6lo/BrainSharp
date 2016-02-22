using System;

namespace BrainSharp.Commands
{
	internal class Input : ICommand
	{
		public State Execute(State state)
		{
			state.Array[state.Pointer] = Console.ReadKey().KeyChar;
			return state;
		}
	}
}