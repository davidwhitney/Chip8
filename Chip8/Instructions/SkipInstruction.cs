namespace Chip8.Instructions
{
    [OpCode("3")]
    public class SkipInstruction : Instruction
    {
        public SkipInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public SkipInstruction() { }
        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            throw new System.NotImplementedException();
        }
    }
}