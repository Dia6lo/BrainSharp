using System;

namespace BrainSharp.Commands
{
	internal class JumpForward : Command
	{
		private readonly Action jumpForward;

		public JumpForward(Action jumpForward)
		{
			this.jumpForward = jumpForward;
		}

		public override void Undo(State state)
		{
			throw new NotImplementedException();
		}

		public override void Redo(State state)
		{
			if (state.Array[state.Pointer] == 0)
			{
				jumpForward();
			}
		}
	}
}