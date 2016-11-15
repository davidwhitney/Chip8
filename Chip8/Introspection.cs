using System;
using System.Collections.Generic;
using System.Linq;

namespace Chip8
{
    public static class Introspection
    {
        public static List<Type> AllInstructions
            => typeof(Decompiler).Assembly.GetTypes()
                .Where(x => x.Name.EndsWith("Instruction"))
                .Where(x => !x.IsAbstract)
                .ToList();
    }
}