using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 23; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine();
            Console.WriteLine("| Sveiki atvyke i magiskojo skaiciaus radima! |");
            for (int i = 0; i < 23; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine();

            int[] digitArrayOne = new int[6];
            int magicNumber = 0;

            for (int i = 100000; i < 1000000; i++)
            {
                digitArrayOne = ToDigitArray(i);
                if (UniqueDigits(digitArrayOne))
                {
                    if (CompareArraysIfSameDigits(digitArrayOne, ToDigitArray(i * 2)) && CompareArraysIfSameDigits(digitArrayOne, ToDigitArray(i * 3)) && CompareArraysIfSameDigits(digitArrayOne, ToDigitArray(i * 4)) && CompareArraysIfSameDigits(digitArrayOne, ToDigitArray(i * 5)) && CompareArraysIfSameDigits(digitArrayOne, ToDigitArray(i * 6)))
                    {
                        magicNumber = i;
                        Console.WriteLine("Magiskasis skaicius rastas! Magiskasis skaicius yra: " + magicNumber);
                        Console.ReadKey();
                    }
                }
            }
        }

        static int[] ToDigitArray(int number)
        {
            int[] result = new int[6];
            for (int i = 0; i < result.Length; i++)
            {
                result[result.Length - i - 1] = number % 10;
                number /= 10;
            }
            return result;
        }

        static bool UniqueDigits(int[] digitArray)
        {
            bool uniqueDigits = true;
            for (int i = 0; i < digitArray.Length; i++)
            {
                for (int j = i + 1; j < digitArray.Length; j++)
                {
                    if (digitArray[i] == digitArray[j])
                    {
                        return uniqueDigits = false;
                    }
                }
            }
            return uniqueDigits;
        }

        static bool CompareArraysIfSameDigits(int[] arrayOne, int[] arrayTwo)
        {
            bool compareArrays = false;
            int countTrue = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        countTrue++;
                    }
                    if (countTrue == 6)
                    {
                        compareArrays = true;
                    }
                }
            }
            return compareArrays;
        }
    }
}
