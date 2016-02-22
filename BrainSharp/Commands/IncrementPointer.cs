namespace BrainSharp.Commands
{
	internal class IncrementPointer : ICommand
	{
		public State Execute(State state)
		{
			state.Pointer++;
			return state;
		}
	}
}