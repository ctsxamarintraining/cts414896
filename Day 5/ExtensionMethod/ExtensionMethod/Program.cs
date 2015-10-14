using System;

namespace ExtensionMethod
{
	public static class Extention
	{
		public static int WordsInString(this string value)
		{
			string[] userString = value.Split(new char[] { ' ' , '.' , '?'},
					StringSplitOptions.RemoveEmptyEntries);
				int wordCount = userString.Length;
				return wordCount;
			} 
			public static int CharInString(this string str)
			{
				int totalCharWithoutSpace = 0;
				string[] userString = str.Split(' ');
				foreach (string stringValue in userString)
				{
					totalCharWithoutSpace += stringValue.Length;
				}
				return totalCharWithoutSpace;
			}
		}




//	class program
//	{
//		public static void Main (string[] args)
//		{
//			string userInput;
//			int noOfWords;
//			int noOfChar;
//
//			Console.WriteLine ("Enter a string");
//			userInput = Console.ReadLine ();
//
//
//		noOfWords = userInput.WordsInString();
//		Console.WriteLine("Total number of words is :"+ noOfWords);
//		//calling Extension Method to count character
//			noOfChar = userInput.CharInString();
//		Console.WriteLine("Total number of character is :"+noOfChar);
//		Console.ReadKey();
//
//		}
//	}
}
