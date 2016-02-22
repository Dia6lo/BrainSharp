using System;

namespace BrainSharp.Commands
{
	internal class JumpForward : ICommand
	{
		private readonly Action jumpForward;

		public JumpForward(Action jumpForward)
		{
			this.jumpForward = jumpForward;
		}

		public State Execute(State state)
		{
			if (state.Array[state.Pointer] == 0)
			{
				jumpForward();
			}
			return state;
		}
	}
}