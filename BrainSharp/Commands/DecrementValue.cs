namespace BrainSharp.Commands
{
	internal class DecrementValue : ICommand
	{
		public State Execute(State state)
		{
			state.Array[state.Pointer]--;
			return state;
		}
	}
}