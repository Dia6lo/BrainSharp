using System;
using System.Collections.Generic;

namespace BrainSharp
{
	internal class InstructionChain
	{
		private readonly List<Instruction> instructions;
		private int pointer;

		public InstructionChain(List<Instruction> instructions)
		{
			this.instructions = instructions;
		}

		public bool Ended => pointer >= instructions.Count;

		public Instruction Current
			=> pointer < 0 || pointer >= instructions.Count ? Instruction.Undefined : instructions[pointer];

		public void JumpToLoopEnd()
		{
			if (Current != Instruction.LoopStart)
			{
				throw new Exception();
			}
			var loop = 1;
			while (loop > 0)
			{
				pointer++;
				switch (Current)
				{
					case Instruction.LoopStart:
						loop++;
						break;
					case Instruction.LoopEnd:
						loop--;
						break;
					case Instruction.Undefined:
						throw new Exception();
				}
			}
		}

		public void JumpToLoopStart()
		{
			if (Current != Instruction.LoopEnd)
			{
				throw new Exception();
			}
			var loop = 1;
			while (loop > 0)
			{
				pointer--;
				switch (Current)
				{
					case Instruction.LoopStart:
						loop--;
						break;
					case Instruction.LoopEnd:
						loop++;
						break;
					case Instruction.Undefined:
						throw new Exception();
				}
			}
			pointer--;
		}

		public void Next()
		{
			pointer++;
		}
	}
}