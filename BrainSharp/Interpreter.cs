using System;
using System.Collections.Generic;
using System.Linq;
using BrainSharp.Commands;
using BrainSharp.InstructionMaps;

namespace BrainSharp
{
	public class Interpreter
	{
		private IInstructionMap instructionMap = new ClassicInstructionMap();
		private InstructionChain instructionChain;
		private State currentState;

		private Dictionary<Instruction, ICommand> commandDictionary;

		public Interpreter(string text, int arraySize = 30000)
		{
			var array = new char[arraySize];
			Array.Clear(array, 0, array.Length);
			currentState = new State(array, 0, "");
			var instructions = text
				.Select(instructionMap.GetInstruction)
				.Where(i => i != Instruction.Undefined)
				.ToList();
			instructionChain = new InstructionChain(instructions);
			commandDictionary = new Dictionary<Instruction, ICommand> {
				{Instruction.IncrementValue, new IncrementValue()},
				{Instruction.DecrementValue, new DecrementValue()},
				{Instruction.IncrementPointer, new IncrementPointer()},
				{Instruction.DecrementPointer, new DecrementPointer()},
				{Instruction.Output, new Output()},
				{Instruction.Input, new Input()},
				{Instruction.LoopStart, new JumpForward(() => {instructionChain.JumpToLoopEnd();})},
				{Instruction.LoopEnd, new JumpBackward(() => { instructionChain.JumpToLoopStart(); })},
				{Instruction.Undefined, null},
			};
		}

		public void Interpret()
		{
			while (instructionChain.Current != Instruction.Undefined) {
				var command = commandDictionary[instructionChain.Current];
				currentState = command.Execute(currentState);
				instructionChain.Next();
			}
			Console.Write(currentState.Output);
		}
	}
}
