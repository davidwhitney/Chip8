namespace Chip8.Instructions
{
    [OpCode("0")]
    public class EndOfFileInstruction : Instruction
    {
        public EndOfFileInstruction(byte byte1, byte byte2) : base(byte1, byte2) { }
        public EndOfFileInstruction() { }

        public override void Execute(ExecutionEnvironment executionEnvironment)
        {
            executionEnvironment.Terminated = true;
        }
    }
}