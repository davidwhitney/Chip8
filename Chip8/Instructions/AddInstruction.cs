namespace Chip8.Instructions
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

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }
}