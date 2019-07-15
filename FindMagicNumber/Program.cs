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
            int[] magicNums = new int[6];
            int[] magicNumsx2 = new int[6];
            int[] magicNumsx3 = new int[6];
            int[] magicNumsx4 = new int[6];
            int[] magicNumsx5 = new int[6];
            int[] magicNumsx6 = new int[6];
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

            for (int i = 102345; i < 999999; i++)
            {
                if (ArrayCheck(IntToArray(i)) == true)
                {
                    num1 = i;
                    magicNums = IntToArray(i);

                    if (ArrayCheck(IntToArray(i * 2)) == true && i * 2 < 999999)
                    {
                        num2 = i * 2;
                        magicNumsx2 = IntToArray(i * 2);
                        if (CompareArrays(magicNums, magicNumsx2) == true)
                        {
                            if (ArrayCheck(IntToArray(i * 3)) == true && i * 3 < 999999)
                            {
                                num3 = i * 3;
                                magicNumsx3 = IntToArray(i * 3);
                                if (CompareArrays(magicNums, magicNumsx3) == true)
                                {
                                    if (ArrayCheck(IntToArray(i * 4)) == true && i * 4 < 999999)
                                    {
                                        num4 = i * 4;
                                        magicNumsx4 = IntToArray(i * 4);
                                        if (CompareArrays(magicNums, magicNumsx4) == true)
                                        {
                                            if (ArrayCheck(IntToArray(i * 5)) == true)
                                            {
                                                num5 = i * 5;
                                                magicNumsx5 = IntToArray(i * 5);
                                                if (CompareArrays(magicNums, magicNumsx5) == true)
                                                {
                                                    if (ArrayCheck(IntToArray(i * 6)) == true)
                                                    {
                                                        num6 = i * 6;
                                                        magicNumsx6 = IntToArray(i * 6);
                                                        if (CompareArrays(magicNums, magicNumsx6) == true)
                                                        {
                                                            Console.WriteLine(num1);
                                                            Console.WriteLine(num2);
                                                            Console.WriteLine(num3);
                                                            Console.WriteLine(num4);
                                                            Console.WriteLine(num5);
                                                            Console.WriteLine(num6);

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
        static int[] IntToArray(int num)
        {
            int[] magicNums = new int[6];
            magicNums[0] = num / 100000;
            magicNums[1] = num / 10000 % 10;
            magicNums[2] = num / 1000 % 10;
            magicNums[3] = num / 100 % 10;
            magicNums[4] = num / 10 % 10;
            magicNums[5] = num % 10;
            return magicNums;
        }

        static bool ArrayCheck(int[] array)
        {
            bool rez = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {
                        rez = false;
                    }
                    else
                    {
                        rez = true;
                    }
                }
            }
            return rez;

        }

        static bool CompareArrays(int[] array1, int[] array2)
        {
            int[] tempArray = new int[6];
            int[] tempArray2 = new int[6];
            array1.CopyTo(tempArray, 0);
            array2.CopyTo(tempArray2, 0);
            Array.Sort(tempArray);
            Array.Sort(tempArray2);
            //foreach (var item in tempArray)
            // {
            //    Console.WriteLine("");
            //   Console.Write(item);
            //}
            if (tempArray[0] == tempArray2[0] &&
                tempArray[1] == tempArray2[1] &&
                tempArray[2] == tempArray2[2] &&
                tempArray[3] == tempArray2[3] &&
                tempArray[4] == tempArray2[4] &&
                tempArray[5] == tempArray2[5]
                )
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
