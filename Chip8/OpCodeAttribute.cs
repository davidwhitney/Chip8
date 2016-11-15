using System;

namespace Chip8
{
    public class OpCodeAttribute : Attribute
    {
        public string Pattern { get; set; }

        public OpCodeAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}