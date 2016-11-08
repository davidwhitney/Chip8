using System.Globalization;

namespace Chip8
{
    public class Instruction
    {
        private byte _byte1;
        private byte _byte2;

        public Instruction(byte byte1, byte byte2)
        {
            _byte1 = byte1;
            _byte2 = byte2;
        }

        public Instruction()
        {
        }

        public byte[] ToByteArray()
        {
            return new[] {_byte1, _byte2};
        }

        public override string ToString()
        {
            return $"{_byte1:X2}{_byte2:X2}";
        }

        public static Instruction FromText(string s)
        {
            var b1 = byte.Parse(s.Substring(0, 2), NumberStyles.HexNumber);
            var b2 = byte.Parse(s.Substring(2, 2), NumberStyles.HexNumber);
            return new Instruction(b1, b2);
        }

        public T ToInstruction<T>() where T: Instruction, new()
        {
            return new T { _byte1 = _byte1, _byte2 = _byte2 };
        }
    }
}