namespace BrainSharp
{
	internal interface ICommand
	{
		State Execute(State state);
	}
}