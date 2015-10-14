using System;

namespace Anonymous
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var myType = new {
				
				Id = "MB005",
				Name = "user",
				City = "Kolkata"

			};
			Console.WriteLine ("ID:{0}\nName:{1}\nCity:{2}", myType.Id, myType.Name, myType.City);
		}
	}
}
