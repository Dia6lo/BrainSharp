using System;

namespace BrainSharp.Commands
{
	internal class Input : Command
	{
		private char previousValue;
		private char inputtedValue;
		private readonly Func<char?> inputChar;

		public Input(Func<char?> inputChar)
		{
			this.inputChar = inputChar;
		}

		public override void Execute(State state)
		{
			previousValue = state.Current;
			var input = inputChar();
			inputtedValue = input ?? (char)0;
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