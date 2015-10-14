using System;

namespace day5third
{
	delegate void Student(int s);
	class MainClass
	{
		public static void Main (string[] args)
		{
			Student p = delegate(int j) {
				j=j+1;
				System.Console.WriteLine ("the value entered is 10 and output is {0}",j);
				System.Console.WriteLine("anonymous method called using delegate");
			};

			p(10);
		}
	}
}
