using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMagicNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input 6 digit number");
            int numberInput;
            numberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is " +numberInput);

           //1. Convertion to array
            Console.WriteLine("Converted input to array");
            // test display
            for (int i = 0; i <= ConvertToArray(numberInput).Length; i++)
            {
                Console.WriteLine(i);
            }
            //2. Check if every element in array ConvertToArray(numberInput) is unique

            
      
            Console.ReadKey();
        }
        static void ConvertToArray2(int numberInput)
        {
            
        }

        //static int ConvertToArray(int numberInput)
        public static int[] ConvertToArray(int numberInput)
        {

            int[] digits = new int[6];
            digits = numberInput.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            return digits;
        }
    }
}
