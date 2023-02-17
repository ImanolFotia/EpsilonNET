

using System;
using System.Runtime.InteropServices;
using Epsilon.Types;


namespace Epsilon
{
    public static class Imports
    {

#if WIN64
    const string libName = "Epsilon.dll"; 
#else
        const string libName = "libEpsilon.so";
#endif


        [DllImport(libName)]
        public extern static void EpsilonInit([MarshalAs(UnmanagedType.LPStr)] string name);

        [DllImport(libName)]
        public extern static void CreateWindow([MarshalAs(UnmanagedType.LPStr)] string name, int w, int h);

        [DllImport(libName)]
        public extern static void CreateContext([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.I4)] Types.renderer_type api);

        [DllImport(libName)]
        public extern static void EpsilonRun();
    }
}