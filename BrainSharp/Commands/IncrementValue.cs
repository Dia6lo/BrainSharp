namespace BrainSharp.Commands
{
	internal class IncrementValue : ICommand
	{
		public State Execute(State state)
		{
			state.Array[state.Pointer]++;
			return state;
		}
	}
}