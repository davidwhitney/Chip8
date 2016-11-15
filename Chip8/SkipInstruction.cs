namespace Chip8
{
    [OpCode("3")]
    public class SkipInstruction : Instruction
    {
        public SkipInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public SkipInstruction() { }
    }
}