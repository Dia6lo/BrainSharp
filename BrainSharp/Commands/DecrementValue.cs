namespace BrainSharp.Commands
{
	internal class DecrementValue : ICommand
	{
		public void Execute(State state)
		{
			state.Array[state.Pointer]--;
		}
	}
}