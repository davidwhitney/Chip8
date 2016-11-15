using NUnit.Framework;

namespace Chip8.Tests
{
    public abstract class InstructionTest
    {
        protected ExecutionEnvironment ExecutionEnvironment;

        [SetUp]
        public void SetUp()
        {
            ExecutionEnvironment = new ExecutionEnvironment();
        }
    }
}