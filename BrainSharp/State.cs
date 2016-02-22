namespace BrainSharp
{
	internal class State
	{
		public readonly char[] Array;
		public string Output;
		public int Pointer;

		public State(char[] array, int pointer, string output)
		{
			Array = array;
			Pointer = pointer;
			Output = output;
		}
	}
}