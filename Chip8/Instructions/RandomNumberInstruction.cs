namespace Chip8.Instructions
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

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }
}