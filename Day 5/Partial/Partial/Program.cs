using System;

namespace Partial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			employee obj = new employee ();
			obj.sayHello ();
			obj.sayHello1 ();
			
		}
	}
	public partial  class employee
	{

		public void sayHello()
		{
			Console.WriteLine ("Hello world");
		}
	}
}
