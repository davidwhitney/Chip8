namespace Chip8
{
    public class SkipInstruction : Instruction
    {
        public SkipInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public SkipInstruction() { }
    }
}