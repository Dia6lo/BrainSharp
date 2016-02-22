namespace BrainSharp.Commands
{
	internal class Output : Command
	{
		public override void Undo(State state)
		{
			throw new System.NotImplementedException();
		}

		public override void Redo(State state)
		{
			state.Output += state.Current;
		}
	}
}