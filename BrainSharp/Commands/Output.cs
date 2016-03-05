using System;

namespace BrainSharp.Commands
{
	internal class Output : Command
	{
		private readonly Action<char> outputChar;
		private readonly Action removeChar;

		public Output(Action<char> outputChar, Action removeChar)
		{
			this.outputChar = outputChar;
			this.removeChar = removeChar;
		}

		public override void Undo(State state)
		{
			removeChar();
		}

		public override void Redo(State state)
		{
			outputChar(state.Current);
		}
	}
}