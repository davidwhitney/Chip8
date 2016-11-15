using Chip8.Instructions;
using NUnit.Framework;

namespace Chip8.Tests
{
    [TestFixture]
    public class EndOfFileInstructionTests : InstructionTest
    {
        [Test]
        public void Execute_Quits()
        {
            var eof = new EndOfFileInstruction();

            eof.Execute(ExecutionEnvironment);

            Assert.That(ExecutionEnvironment.Terminated, Is.True);
        }
    }
    [TestFixture]
    public class JumpInstructionTests : InstructionTest
    {
        [Test]
        public void Execute_Quits()
        {
            var eof = new JumpInstruction();

            eof.Execute(ExecutionEnvironment);

            Assert.That(ExecutionEnvironment.Terminated, Is.True);
        }
    }
}