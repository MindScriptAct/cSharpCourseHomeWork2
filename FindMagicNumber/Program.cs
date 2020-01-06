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
            /*
            for (int i = 0; i <= ConvertToArray(numberInput).Length; i++)
            {
                Console.WriteLine(i);
            }
            */

            //2. Check if every element in array ConvertToArray(numberInput) is unique
            //CheckIfUniqueElement(ConvertToArray(numberInput));
             if (CheckIfUniqueElement(ConvertToArray(numberInput)))
             {
                Console.WriteLine("All array elements are unique");
                //3.
                Check2XResult(numberInput);
             }

            Console.ReadKey();
        }

        //static int ConvertToArray(int numberInput)
        public static int[] ConvertToArray(int numberInput)
        {
            int[] digits = new int[6];
            digits = numberInput.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            return digits;
        }
        public static bool CheckIfUniqueElement(int[] digits)
        {
            bool isUnique = false;
            if (digits.Distinct().Count() == digits.Count())
            {
                isUnique = true;
               
            }
            return isUnique;
        }

        public static bool Check2XResult(int numberInput)
        {
            bool resultCheck = false;
            int num2x = numberInput * 2;
            Console.WriteLine("Converted number "+ num2x);

            //convert to array num2x
            if (ConvertToArray(num2x).Length == 6)
            {
                Console.WriteLine("Varom toliau");
                //check if array ConvertToArray(num2x) has same elements as array ConvertToArray(numberInput), but in different positions
                Array2xCheck(ConvertToArray(num2x), ConvertToArray(numberInput));

            }
            else Console.WriteLine("false");
            
          
            
            return resultCheck;
        }
        public static bool Array2xCheck(int[] digits, int[] digitsOriginal)
        {
            bool result = false;
            // check if array digits has same elements as array digitsOriginal
            for (int i = 0; i <= digits.Length; i++)
            {
                //if (digitsOriginal.find(i))
                Console.WriteLine(i);
            }

            return result;
        }

    }
}
