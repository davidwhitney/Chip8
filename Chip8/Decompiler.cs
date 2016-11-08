using System;
using System.Collections.Generic;

namespace Chip8
{
    public class Decompiler
    {
        public List<Instruction> Decompile(byte[] data)
        {
            var instructions = new List<Instruction>();

            for (var index = 0; index < data.Length; index += 2)
            {
                var instruction = new Instruction(data[index], data[index+1]);
                instructions.Add(SelectInstruction(instruction));
            }

            return instructions;
        }

        private static Instruction SelectInstruction(Instruction instruction)
        {
            if (instruction.ToString() == "0000")
            {
                return instruction.ToInstruction<EndOfFileInstruction>();
            }

            if (instruction.ToString().StartsWith("1"))
            {
                return instruction.ToInstruction<JumpInstruction>();
            }

            if (instruction.ToString().StartsWith("3"))
            {
                return instruction.ToInstruction<SkipInstruction>();
            }

            if (instruction.ToString().StartsWith("6"))
            {
                return instruction.ToInstruction<AssignInstruction>();
            }
            return instruction;
        }
    }
}