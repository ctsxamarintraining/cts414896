using System;

namespace ExtensionMethod
{
	class program
	{
		public static void Main (string[] args)
		{
			string userInput;
			int noOfWords;
			int noOfChar;

			Console.WriteLine ("Enter a string");
			userInput = Console.ReadLine ();


			noOfWords = userInput.WordsInString();
			Console.WriteLine("Total number of words is :"+ noOfWords);
			//calling Extension Method to count character
			noOfChar = userInput.CharInString();
			Console.WriteLine("Total number of character is :"+noOfChar);
			Console.ReadKey();

		}
	}
}

