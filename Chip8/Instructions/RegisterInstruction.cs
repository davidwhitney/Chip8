namespace Chip8.Instructions
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

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }
}