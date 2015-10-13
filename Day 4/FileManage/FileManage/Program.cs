using System;
using System.IO;
using System.Text;

namespace FileManage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string path = @"/Users/macmini6/Desktop/example.docx";


			try{
			     if (File.Exists (path)) {
				string readText = File.ReadAllText (path);
				Console.WriteLine (readText);

			 } 
			}
			catch(PathTooLongException e) {

				Console.WriteLine ("Exception caught: {0}", e);
			}
			catch(NullReferenceException e) {

				Console.WriteLine ("Exception caught: {0}", e);
			}
			finally {

				Console.WriteLine ("this is a demo");
			}



		

		}
	}
}
