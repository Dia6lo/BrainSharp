using System;
using System.Collections.Generic;
using System.Linq;
using BrainSharp.Commands;
using BrainSharp.InstructionMaps;

namespace BrainSharp
{
	public class Interpreter
	{
		private readonly Dictionary<Instruction, ICommand> commandDictionary;
		private State currentState;
		private readonly InstructionChain instructionChain;
		private readonly IInstructionMap instructionMap = new ClassicInstructionMap();

		public Interpreter(string text, int arraySize = 30000)
		{
			currentState = new State(new char[arraySize], 0, "");
			var instructions = text
				.Select(instructionMap.GetInstruction)
				.Where(i => i != Instruction.Undefined)
				.ToList();
			instructionChain = new InstructionChain(instructions);
			commandDictionary = new Dictionary<Instruction, ICommand>
			{
				{Instruction.IncrementValue, new IncrementValue()},
				{Instruction.DecrementValue, new DecrementValue()},
				{Instruction.IncrementPointer, new IncrementPointer()},
				{Instruction.DecrementPointer, new DecrementPointer()},
				{Instruction.Output, new Output()},
				{Instruction.Input, new Input()},
				{Instruction.LoopStart, new JumpForward(() => { instructionChain.JumpToLoopEnd(); })},
				{Instruction.LoopEnd, new JumpBackward(() => { instructionChain.JumpToLoopStart(); })},
				{Instruction.Undefined, null}
			};
		}

		public void Interpret()
		{
			while (!instructionChain.Ended)
			{
				var command = commandDictionary[instructionChain.Current];
				command.Execute(currentState);
				instructionChain.Next();
			}
			Console.Write(currentState.Output);
		}
	}
}