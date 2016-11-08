using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Chip8
{
    [TestFixture]
    public class DecompilerTests
    {
        private byte[] _data;
        private Decompiler _decompiler;

        [SetUp]
        public void SetUp()
        {
            _data = File.ReadAllBytes("Chip8Test.bin");
            _decompiler = new Decompiler();
        }

        [Test]
        public void Decompiler_Decompile_ReturnsListOfOpcodes()
        {
            var result = _decompiler.Decompile(_data);

            Assert.That(result[0].ToString(), Is.EqualTo("6177"));
        }

        [Test]
        public void Decompile_InstructionIsFourZeros_ReturnsExit()
        {
            var exitInstruction = Instruction.FromText("0000");

            var decompiled = _decompiler.Decompile(exitInstruction.ToByteArray());

            Assert.That(decompiled.First(), Is.TypeOf<EndOfFileInstruction>());
        }

        [Test]
        public void Decompile_InstructionIs1NNN_JumpToAddressNNN()
        {
            var instruction = Instruction.FromText("1000");

            var decompiled = _decompiler.Decompile(instruction.ToByteArray());

            Assert.That(decompiled.First(), Is.TypeOf<JumpInstruction>());
        }

        [Test]
        public void Decompile_InstructionIs3XKK_SkipInstruction()
        {
            var instructions = Instruction.FromText("3011").ToByteArray();

            var decompiled = _decompiler.Decompile(instructions);

            Assert.That(decompiled.First(), Is.TypeOf<SkipInstruction>());
        }

        [Test]
        public void Decompile_InstructionIs6XKK_AssignInstruction()
        {
            var instructions = Instruction.FromText("6011").ToByteArray();

            var decompiled = _decompiler.Decompile(instructions);

            Assert.That(decompiled.First(), Is.TypeOf<AssignInstruction>());
        }


    }
}
