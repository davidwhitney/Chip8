namespace Chip8
{
    [OpCode("8")]
    public class RegisterInstruction : Instruction
    {
        public RegisterInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public RegisterInstruction()
        {
            
        }
    }
}