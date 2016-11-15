using System.Collections.Generic;
using System.Linq;
using Chip8.Instructions;

namespace Chip8
{
    public class Decompiler
    {
        public List<Instruction> Decompile(byte[] data)
        {
            var instructions = new List<Instruction>();

            for (var index = 0; index < data.Length; index += 2)
            {
                var instruction = new UnidentifiedInstruction(data[index], data[index+1]);
                var type = Introspection.AllInstructions.Single(
                            inst => instruction.ToString().StartsWith(inst.GetOpCodeAttribute()?.Pattern));

                instructions.Add(instruction.ToInstruction(type));
            }

            return instructions;
        }
    }
}