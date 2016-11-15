using System;

namespace Chip8
{
    [OpCode("Unidentified")]
    public class UnidentifiedInstruction : Instruction
    {
        public UnidentifiedInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public Instruction ToInstruction(Type targetType)
        {
            return (Instruction)Activator.CreateInstance(targetType, Byte1, Byte2);
        }

    }
}