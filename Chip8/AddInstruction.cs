namespace Chip8
{
    [OpCode("7")]
    public class AddInstruction : Instruction
    {
        public AddInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public AddInstruction()
        {
            
        }
    }
}