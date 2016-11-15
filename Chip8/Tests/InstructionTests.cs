using Chip8.Instructions;
using NUnit.Framework;

namespace Chip8.Tests
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

        [Test]
        public void MakeSureAllInstructionsHaveAttributes()
        {
            foreach (var inst in Introspection.AllInstructions)
            {
                var opCode = inst.GetOpCodeAttribute();
                Assert.That(opCode, Is.Not.Null, $"{inst.Name} does not have an opcode attribute");
            }
        }
    }
}