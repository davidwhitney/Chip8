namespace Chip8
{
    [OpCode("0")]
    public class EndOfFileInstruction : Instruction
    {
        public EndOfFileInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public EndOfFileInstruction() { }
    }
}