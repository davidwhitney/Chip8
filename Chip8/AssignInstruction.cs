﻿namespace Chip8
{
    [OpCode("6")]
    public class AssignInstruction : Instruction
    {
        public AssignInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public AssignInstruction()
        {
            
        }
    }
}