﻿using System.Runtime.InteropServices;

namespace FixPluginTypesSerialization.UnityPlayer.Structs.v2018
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AssemblyList
    {
        public AssemblyStringStruct* first;
        public AssemblyStringStruct* last;
        public AssemblyStringStruct* end;
    }
}
