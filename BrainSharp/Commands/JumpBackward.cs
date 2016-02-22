using System;

namespace BrainSharp.Commands
{
	internal class JumpBackward : ICommand
	{
		private readonly Action jumpBackward;

		public JumpBackward(Action jumpBackward)
		{
			this.jumpBackward = jumpBackward;
		}

		public State Execute(State state)
		{
			if (state.Array[state.Pointer] != 0)
			{
				jumpBackward();
			}
			return state;
		}
	}
}