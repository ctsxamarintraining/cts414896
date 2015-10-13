using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx2Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int[] arr = new int[] {23, 8, 9, 11, 22 };
            int size = arr.Length + 2;
                ;
           
            StringBuilder sb = new StringBuilder ();
            
            for(int i=0;i<arr.Length;i++)
            {
                sb.Append(arr[i]);
                sb.Append(",");
            }

            for (int j = 0; j < 2; j++) { 
                    Console.Write ("Please add an elements to array:  ");
                    int num= Convert.ToInt32( Console.ReadLine ());
                    sb.Append(num);
                    sb.Append(",");
                    Console.WriteLine("Numbers in the array : {0}", sb.ToString().TrimEnd(','));

            }

           
            Console.ReadKey();
            }

            catch(IndexOutOfRangeException ex) {
                Console.WriteLine (ex.Message);
            }

            catch(FormatException ex) 
            {
                Console.WriteLine (ex.Message);
            }
            catch(Exception ex)
            {
            Console.WriteLine (" Some exception need to be handled ");
            Console.ReadKey();
            }
        }
    }
}
