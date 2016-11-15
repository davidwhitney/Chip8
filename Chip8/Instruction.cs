using System.Globalization;

namespace Chip8
{
    public abstract class Instruction
    {
        internal byte Byte1;
        internal byte Byte2;

        protected Instruction(byte byte1, byte byte2)
        {
            Byte1 = byte1;
            Byte2 = byte2;
        }

        protected Instruction()
        {
        }

        public byte[] ToByteArray()
        {
            return new[] {Byte1, Byte2};
        }

        public override string ToString()
        {
            return $"{Byte1:X2}{Byte2:X2}";
        }

        public static Instruction FromText(string s)
        {
            var b1 = byte.Parse(s.Substring(0, 2), NumberStyles.HexNumber);
            var b2 = byte.Parse(s.Substring(2, 2), NumberStyles.HexNumber);
            return new UnidentifiedInstruction(b1, b2);
        }
    }
}