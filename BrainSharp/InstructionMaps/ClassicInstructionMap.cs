namespace BrainSharp.InstructionMaps
{
	public class ClassicInstructionMap: IInstructionMap
	{
		public Instruction GetInstruction(char c)
		{
			switch (c) {
				case '+':
					return Instruction.IncrementValue;
				case '-':
					return Instruction.DecrementValue;
				case '>':
					return Instruction.IncrementPointer;
				case '<':
					return Instruction.DecrementPointer;
				case '.':
					return Instruction.Output;
				case ',':
					return Instruction.Input;
				case '[':
					return Instruction.LoopStart;
				case ']':
					return Instruction.LoopEnd;
				default:
					return Instruction.Undefined;
			}
		}
	}
}
