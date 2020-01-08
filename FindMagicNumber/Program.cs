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
           // Console.WriteLine("Converted input to array");
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
             var result = new int[numDigits(numberInput)];
           
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = numberInput % 10;
                numberInput /= 10;
            }
          
            return result;
        }
        public static int numDigits(int n)
        {
            if (n < 0)
            {
                n = (n == Int32.MinValue) ? Int32.MaxValue : -n;
            }
            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
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
                //check if array ConvertToArray(num2x) has same elements as array ConvertToArray(numberInput), but in different positions
                ArrayCheck(ConvertToArray(num2x), ConvertToArray(numberInput));

                
                if (ArrayCheck(ConvertToArray(num2x), ConvertToArray(numberInput)))
                {
                    Console.WriteLine("Passed");
                   // Console.WriteLine("Number "+ numberInput + "is a Magic Number!");
                   // Console.WriteLine(numberInput  + " " + num2x);
                    // check with numberInput* 3
                }
                else
                Console.WriteLine("Number " + numberInput + "is not a Magic Number!");
                
            }
            else Console.WriteLine("false");
            
          
            
            return resultCheck;
        }
        public static bool ArrayCheck(int[] digits, int[] digitsOriginal)
        {
            bool result = false;
            int resultCheck = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                int pos = Array.IndexOf(digitsOriginal, digits[i]);
                if (pos > -1)
                {
                    if (pos !=i)
                    {
                        resultCheck++;
                    }
                }
            }
            if (resultCheck == digitsOriginal.Length)
            {
                result = true;
            }
            return result;
        }

    }
}
