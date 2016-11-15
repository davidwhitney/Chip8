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

        [TestCase("0000", typeof(EndOfFileInstruction))]
        [TestCase("1000", typeof(JumpInstruction))]
        [TestCase("3011", typeof(SkipInstruction))]
        [TestCase("6011", typeof(AssignInstruction))]
        [TestCase("7011", typeof(AddInstruction))]
        [TestCase("8010", typeof(RegisterInstruction))]
        [TestCase("8011", typeof(RegisterInstruction))]
        [TestCase("C011", typeof(RandomNumberInstruction))]
        public void Decompile_MapsToInstanceOfInstruction(string instText, Type expectedInstance)
        {
            var instruction = Instruction.FromText(instText);

            var decompiled = _decompiler.Decompile(instruction.ToByteArray());

            Assert.That(decompiled.First(), Is.TypeOf(expectedInstance));
        }


    }
}
