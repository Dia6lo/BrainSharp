using System;

namespace BrainSharp.Commands
{
	internal class JumpBackward : Command
	{
		private readonly Action jumpBackward;

		public JumpBackward(Action jumpBackward)
		{
			this.jumpBackward = jumpBackward;
		}

		public override void Undo(State state)
		{
			throw new NotImplementedException();
		}

		public override void Redo(State state)
		{
			if (state.Current != 0)
			{
				jumpBackward();
			}
		}
	}
}