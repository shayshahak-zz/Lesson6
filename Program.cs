using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter a name");
            //string myName = Console.ReadLine();
            //switch (myName)
            //{
            //    case "avi":
            //        Console.WriteLine("Hello");
            //        break;

            //    case "liraz":
            //        Console.WriteLine("World");
            //        break;

            //    case "shalom":
            //        Console.WriteLine("David");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid number!");
            //        break;

            //}

            int theSum = 0;
            Console.WriteLine("please enter length");
            int index = int.Parse(Console.ReadLine());
            int[] myArray = new int[index];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("enter number");
                myArray[i] = int.Parse(Console.ReadLine());
                theSum = theSum + myArray[i];
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("the number is {0}",myArray[i]);               
            }
            Console.WriteLine("the sum is {0}", theSum);
            Console.WriteLine("the average is {0}", theSum / myArray.Length);
        }
    }
}
