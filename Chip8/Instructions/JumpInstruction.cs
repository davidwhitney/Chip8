namespace Chip8.Instructions
{
    [OpCode("1")]
    public class JumpInstruction : Instruction
    {
        public JumpInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public JumpInstruction() { }

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }

 
}