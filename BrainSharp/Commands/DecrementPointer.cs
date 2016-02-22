namespace BrainSharp.Commands
{
	internal class DecrementPointer : ICommand
	{
		public void Execute(State state)
		{
			state.Pointer--;
		}
	}
}