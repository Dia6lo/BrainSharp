using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSharp
{
	class InstructionChain
	{
		private List<Instruction> instructions;
		private int pointer;

		public InstructionChain(List<Instruction> instructions)
		{
			this.instructions = instructions;
		}

		public void JumpToLoopEnd()
		{
			if (Current != Instruction.LoopStart) {
				throw new Exception();
			}
			var loop = 1;
			while (loop > 0) {
				pointer++;
				switch (Current) {
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
			if (Current != Instruction.LoopEnd) {
				throw new Exception();
			}
			var loop = 1;
			while (loop > 0) {
				pointer--;
				switch (Current) {
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

		public Instruction Current => pointer < 0 || pointer >= instructions.Count ? Instruction.Undefined : instructions[pointer];
	}
}
