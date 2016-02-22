namespace BrainSharp.Commands
{
	internal class IncrementPointer : Command
	{
		public override void Undo(State state) => state.Pointer--;
		public override void Redo(State state) => state.Pointer++;
	}
}