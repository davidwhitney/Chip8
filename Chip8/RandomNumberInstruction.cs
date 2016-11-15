namespace Chip8
{
    [OpCode("C")]
    public class RandomNumberInstruction : Instruction
    {
        public RandomNumberInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public RandomNumberInstruction()
        {
            
        }
    }
}