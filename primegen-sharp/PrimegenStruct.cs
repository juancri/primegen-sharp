using System;
using System.Runtime.InteropServices;

namespace primegensharp
{
	[StructLayout (LayoutKind.Sequential)]
	public struct PrimegenStruct
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 2048)]
		public uint[] buf;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public ulong[] p;
		public int num;
		public int pos;
		public ulong baseNumber;
		public ulong L;

		public static PrimegenStruct Create ()
		{
			return new PrimegenStruct
			{
				buf = new uint [16 * 2048],
				p = new ulong [512]
			};
		}
	}
}

