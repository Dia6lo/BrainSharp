namespace BrainSharp.Commands
{
	internal class Output : ICommand
	{
		public void Execute(State state)
		{
			state.Output += state.Array[state.Pointer];
		}
	}
}