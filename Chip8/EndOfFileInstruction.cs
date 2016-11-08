namespace Chip8
{
    public class EndOfFileInstruction : Instruction
    {
        public EndOfFileInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public EndOfFileInstruction() { }
    }
}