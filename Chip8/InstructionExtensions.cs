using System;
using System.Linq;

namespace Chip8
{
    public static class InstructionExtensions
    {
        public static OpCodeAttribute GetOpCodeAttribute(this Type instruction)
        {
            return instruction.GetCustomAttributes(typeof(OpCodeAttribute), true).Cast<OpCodeAttribute>().SingleOrDefault();
        }
    }
}