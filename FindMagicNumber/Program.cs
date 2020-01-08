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

            

            if (MagicNumber(numberInput))
            {
                Console.WriteLine(numberInput + " is a Magic Number!");
            }
            else
            {
                Console.WriteLine("Number " + numberInput + " is not a Magic Number!");
            }
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
            /*
             if (CheckIfUniqueElement(ConvertToArray(numberInput)))
             {

                Console.WriteLine("All array elements are unique");
                //3.
                int num2x = numberInput * 2;
                int num3x = numberInput * 3;
                int num4x = numberInput * 4;
                int num5x = numberInput * 5;
                int num6x = numberInput * 6;

                CheckNumberResult(num2x, numberInput);

                if (CheckNumberResult(num2x, numberInput))
                {
                    Console.WriteLine("Multiplication 2x passed! "+ num2x);
                }
                else
                {
                    Console.WriteLine("Number " + numberInput + "is not a Magic Number!");
                }
             }
             */

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

        public static bool CheckNumberResult(int newNum, int numberInput)
        {
            bool resultCheck = false;
            Console.WriteLine("Converted number "+ newNum);

            //convert to array num2x
            if (ConvertToArray(newNum).Length == 6)
            {
                //check if array ConvertToArray(num2x) has same elements as array ConvertToArray(numberInput), but in different positions
                ArrayCheck(ConvertToArray(newNum), ConvertToArray(numberInput));
                if (ArrayCheck(ConvertToArray(newNum), ConvertToArray(numberInput)))
                {
                    resultCheck = true;
                }  
            }
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
        public static bool MagicNumber(int numberInput)
        {
            bool magicNumber = false;
            if (CheckIfUniqueElement(ConvertToArray(numberInput)))
            {
                Console.WriteLine("All array elements are unique");
                //3.
                int num2x = numberInput * 2;
                int num3x = numberInput * 3;
                int num4x = numberInput * 4;
                int num5x = numberInput * 5;
                int num6x = numberInput * 6;

                //CheckNumberResult(num2x, numberInput);

                if (CheckNumberResult(num2x, numberInput))
                {
                    Console.WriteLine("Multiplication 2x passed! " + num2x);
                    if (CheckNumberResult(num3x, numberInput))
                    {
                        Console.WriteLine("Multiplication 3x passed! " + num3x);
                        if (CheckNumberResult(num4x, numberInput))
                        {
                            Console.WriteLine("Multiplication 4x passed! " + num4x);
                            if (CheckNumberResult(num5x, numberInput))
                            {
                                Console.WriteLine("Multiplication 5x passed! " + num5x);
                                if (CheckNumberResult(num6x, numberInput))
                                {
                                    Console.WriteLine("Multiplication 6x passed! " + num6x);
                                    magicNumber = true;
                                }
                            }
                        }
                    }         
                }
            }
            return magicNumber;
        }
    }
}
