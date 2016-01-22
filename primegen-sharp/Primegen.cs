using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace primegensharp
{
	public static class Primegen
	{
		// Constructor

		public static IEnumerable <ulong> Get ()
		{
			var pg = PrimegenStruct.Create ();
			primegen_init(ref pg);
			while (true)
				yield return primegen_next (ref pg);
		}



		// External

		[DllImport ("primegen")]
		private static extern void primegen_init(ref PrimegenStruct pg);

		[DllImport ("primegen")]
		private static extern ulong primegen_next(ref PrimegenStruct pg);
	}
}

