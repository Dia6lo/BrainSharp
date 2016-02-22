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

		public void Execute(State state)
		{
			if (state.Array[state.Pointer] != 0)
			{
				jumpBackward();
			}
		}
	}
}