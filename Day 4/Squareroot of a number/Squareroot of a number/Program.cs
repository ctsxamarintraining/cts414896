using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squareroot_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
          int a=0;
			double b;
			try{
				Console.WriteLine("Enter Number : ");
			    a = Convert.ToInt32 (Console.ReadLine ());
				if(a<0)
					Console.WriteLine("Invalid number");
				else
				{
                    b = Math.Sqrt (a);
                    Console.WriteLine("Square root of {0} is: {1}", a, b);
				}
			}
			catch(FormatException)
			{
				
					Console.WriteLine ("Invalid Number");
				
			}

			finally{ 
				Console.WriteLine ("Goodbye");
                Console.ReadLine();
			}

        }
      
    }
}
