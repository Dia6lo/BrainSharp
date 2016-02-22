namespace BrainSharp.InstructionMaps
{
	public class PetoohInstructionMap: IInstructionMap
	{
		// TODO
		public Instruction GetInstruction(char c)
		{
			switch (c) {
				case '+':
					return Instruction.DecrementValue;
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
