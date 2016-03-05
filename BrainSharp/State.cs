namespace BrainSharp
{
	internal class State
	{
		private readonly char[] array;

		public State(int arraySize)
		{
			array = new char[arraySize];
		}

		public char Current
		{
			get { return array[Pointer]; }
			set { array[Pointer] = value; }
		}

		public int Pointer { get; set; }
	}
}