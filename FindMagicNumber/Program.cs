using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = 0;
            int multipliedBySixNr = 0;
            int multipliedByFiveNr = 0;
            int multipliedByFourNr = 0;
            int multipliedByThreeNr = 0;
            int multipliedByTwoNr = 0;

            int[] magicNrArray = new int[6];
            int[] myArray2 = new int[6];
            int[] myArray3 = new int[6];
            int[] myArray4 = new int[6];
            int[] myArray5 = new int[6];
            int[] myArray6 = new int[6];

            Random random = new Random();

            while (
                CheckIfBadNumber(magicNrArray, multipliedBySixNr) == true ||
                NumbersDublicate(myArray2) == true ||
                ArraysContainSameNubers(magicNrArray, myArray2) == false ||
                NumbersDublicate(myArray3) == true ||
                ArraysContainSameNubers(magicNrArray, myArray3) == false)
            {
                int randomNumber = random.Next(100000, 999999);

                AddToArray(ConvertToString(randomNumber), magicNrArray);

                if (NumbersDublicate(magicNrArray) == true)
                {
                    continue;
                }

                magicNumber = ConvertToInt(magicNrArray);

                multipliedBySixNr = magicNumber * 6;

                if (NumberTooBig(multipliedBySixNr) == true)
                {
                    continue;
                }

                AddToArray(ConvertToString(multipliedBySixNr), myArray2);

                if (NumbersDublicate(myArray2) == true)
                {
                    continue;
                }
        
                if (ArraysContainSameNubers(magicNrArray, myArray2) == true)
                {
                    multipliedByFiveNr = magicNumber * 5;

                    AddToArray(ConvertToString(multipliedByFiveNr), myArray3);

                    if (NumbersDublicate(myArray3) == true)
                    {
                        continue;
                    }

                    if (ArraysContainSameNubers(magicNrArray, myArray3) == true)
                    {
                        multipliedByFourNr = magicNumber * 4;
                        multipliedByThreeNr = magicNumber * 3;
                        multipliedByTwoNr = magicNumber * 2;

                        AddToArray(ConvertToString(multipliedByFourNr), myArray4);
                        AddToArray(ConvertToString(multipliedByThreeNr), myArray5);
                        AddToArray(ConvertToString(multipliedByTwoNr), myArray6);

                        if (ArraysContainSameNubers(magicNrArray, myArray4) == true &&
                            ArraysContainSameNubers(magicNrArray, myArray5) == true &&
                            ArraysContainSameNubers(magicNrArray, myArray6) == true)
                        {
                            Console.WriteLine($"Magiskas skaicius yra {magicNumber}");
                            Console.WriteLine($"Jis padaugintas iš 6 yra {multipliedBySixNr}");
                            Console.WriteLine($"Jis padaugintas iš 5 yra {multipliedByFiveNr}");
                            Console.WriteLine($"Jis padaugintas iš 4 yra {multipliedByFourNr}");
                            Console.WriteLine($"Jis padaugintas iš 3 yra {multipliedByThreeNr}");
                            Console.WriteLine($"Jis padaugintas iš 2 yra {multipliedByTwoNr}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        static string ConvertToString(int number)
        {
            return Convert.ToString(number);
        }

        static void AddToArray(string NrToString, int[] myArray)
        {
            for (int i = 0; i < NrToString.Length; i++)
            {
                myArray[i] = NrToString[i] - '0';
            }
        }

        static bool CheckIfBadNumber(int[] myArray, int number)
        {
            return NumbersDublicate(myArray) || NumberTooBig(number);
        }

        static bool NumbersDublicate(int[] myArray)
        {
            return (
                myArray[0] == myArray[1] ||
                myArray[0] == myArray[2] ||
                myArray[0] == myArray[3] ||
                myArray[0] == myArray[4] ||
                myArray[0] == myArray[5] ||
                myArray[1] == myArray[2] ||
                myArray[1] == myArray[3] ||
                myArray[1] == myArray[4] ||
                myArray[1] == myArray[5] ||
                myArray[2] == myArray[3] ||
                myArray[2] == myArray[4] ||
                myArray[2] == myArray[5] ||
                myArray[3] == myArray[4] ||
                myArray[3] == myArray[5] ||
                myArray[4] == myArray[5]);
        }

        static int ConvertToInt(int[] myArray)
        {
            int myNumber = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myNumber += myArray[i] * Convert.ToInt32(Math.Pow(10, myArray.Length - i - 1));
            }
            return myNumber;
        }

        static bool NumberTooBig(int number)
        {
            return number > 999999;
        }

        static bool ArraysContainSameNubers(int[] arrayA, int[] arrayB)
        {
            bool value = true;

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] != arrayB[j])
                    {
                        if (j == arrayB.Length - 1)
                        {
                            value = false;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (value == false)
                {
                    break;
                }
            }
            if (value == false)
            {
                return value;
            }
            else
            {
                return true;
            }
        }
    }
}
