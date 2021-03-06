﻿using System.Collections.Generic;
using System.Linq;
using BrainSharp.Commands;
using BrainSharp.InstructionMaps;

namespace BrainSharp
{
	public class Interpreter
	{
		private readonly Dictionary<Instruction, Command> commandDictionary;
		private readonly State state;
		private readonly InstructionChain instructionChain;

		public Interpreter(string text, int arraySize = 30000)
		{
			state = new State(arraySize);
			var instructions = text
				.Select(InstructionMap.GetInstruction)
				.Where(i => i != Instruction.Undefined)
				.ToList();
			instructionChain = new InstructionChain(instructions);
			commandDictionary = new Dictionary<Instruction, Command>
			{
				{Instruction.IncrementValue, new IncrementValue()},
				{Instruction.DecrementValue, new DecrementValue()},
				{Instruction.IncrementPointer, new IncrementPointer()},
				{Instruction.DecrementPointer, new DecrementPointer()},
				{Instruction.Output, new Output(
					c => {OutputHandler?.OutputChar(c);},
					() => {OutputHandler?.RemoveChar();}
					)},
				{Instruction.Input, new Input(() => InputHandler?.InputChar())},
				{Instruction.LoopStart, new JumpForward(() => { instructionChain.JumpToLoopEnd(); })},
				{Instruction.LoopEnd, new JumpBackward(() => { instructionChain.JumpToLoopStart(); })},
				{Instruction.Undefined, null}
			};
		}

		public IOutputHandler OutputHandler { get; set; }
		public IInputHandler InputHandler { get; set; }
		public IInstructionMap InstructionMap { get; set; } = new ClassicInstructionMap();

		public void Interpret()
		{
			while (!instructionChain.Ended)
			{
				var command = commandDictionary[instructionChain.Current];
				command.Execute(state);
				instructionChain.Next();
			}
		}
	}
}