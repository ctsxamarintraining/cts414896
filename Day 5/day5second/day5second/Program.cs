using System;

namespace day5second
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//int? i = null;
			Nullable<int> i = null;
			Console.WriteLine (i.HasValue);

			i = 10;
			Console.WriteLine (i.Value);

		}
	}
}
