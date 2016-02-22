namespace BrainSharp.Commands
{
	internal class DecrementPointer : ICommand
	{
		public State Execute(State state)
		{
			state.Pointer--;
			return state;
		}
	}
}