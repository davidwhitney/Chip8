namespace Chip8.Instructions
{
    [OpCode("6")]
    public class AssignInstruction : Instruction
    {
        public AssignInstruction(byte byte1, byte byte2) : base(byte1, byte2)
        {
        }

        public AssignInstruction()
        {
            
        }

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }
}