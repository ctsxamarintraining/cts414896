using System;

using System.Collections.Generic;

namespace Reversing_File
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] lines = { "First line", "Second line", "Third line" };
			System.IO.File.WriteAllLines(@"/Users/Macmini10/Desktop/WriteLines.txt", lines);
			var log = System.IO.File.ReadLines(@"/Users/Macmini10/Desktop/WriteLines.txt"); 
			string temp = string.Join (",", log);
			Console.WriteLine (temp);
			string[] temp1 = temp.Split (',');
			Console.WriteLine (temp1);
			Array.Reverse (temp1);
			System.IO.File.WriteAllLines(@"/Users/Macmini10/Desktop/WriteLines1.txt", temp1);
		}
	}
}
