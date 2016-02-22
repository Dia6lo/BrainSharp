namespace BrainSharp.Commands
{
	internal class Output : ICommand
	{
		public State Execute(State state)
		{
			state.Output += state.Array[state.Pointer];
			return state;
		}
	}
}