namespace BrainSharp.Commands
{
	internal class IncrementValue : ICommand
	{
		public void Execute(State state)
		{
			state.Array[state.Pointer]++;
		}
	}
}