namespace BrainSharp.Commands
{
	internal class IncrementPointer : ICommand
	{
		public void Execute(State state)
		{
			state.Pointer++;
		}
	}
}