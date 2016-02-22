namespace BrainSharp
{
	internal interface ICommand
	{
		void Execute(State state);
	}
}