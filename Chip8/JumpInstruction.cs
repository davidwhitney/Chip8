namespace Chip8
{
    public class JumpInstruction : Instruction
    {
        public JumpInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public JumpInstruction() { }
    }
}