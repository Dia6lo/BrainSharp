namespace BrainSharp
{
	internal class State
	{
		public char[] Array;
		public int Pointer;
		public string Output;

		public State(char[] array, int pointer, string output)
		{
			Array = array;
			Pointer = pointer;
			Output = output;
		}
	}
}
