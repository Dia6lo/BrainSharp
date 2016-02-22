namespace BrainSharp
{
	internal abstract class Command
	{
		public virtual void Execute(State state)
		{
			Redo(state);
		}

		public abstract void Undo(State state);
		public abstract void Redo(State state);
	}
}