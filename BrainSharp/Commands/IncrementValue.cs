namespace BrainSharp.Commands
{
	internal class IncrementValue : Command
	{
		public override void Undo(State state) => state.Current--;
		public override void Redo(State state) => state.Current++;
	}
}