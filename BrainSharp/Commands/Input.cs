using System;

namespace BrainSharp.Commands
{
	internal class Input : Command
	{
		private char previousValue;
		private char inputtedValue;

		public override void Execute(State state)
		{
			previousValue = state.Current;
			inputtedValue = Console.ReadKey().KeyChar;
			base.Execute(state);
		}

		public override void Undo(State state)
		{
			state.Current = previousValue;
		}

		public override void Redo(State state)
		{
			state.Current = inputtedValue;
		}
	}
}