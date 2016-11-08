using NUnit.Framework;

namespace Chip8
{
    [TestFixture]
    public class InstructionTests
    {
        [Test]
        public void FromText_CreatesInstruction()
        {
            var instruction = Instruction.FromText("0000");

            Assert.That(instruction.ToString(), Is.EqualTo("0000"));
        }
    }
}