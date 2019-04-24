using System;

namespace NamuDarbas2_MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntToTest = new int[6];
            int[] IntMultiplied = new int[6];

            for (int i = 100000; i < 1000000; i++)
            {
                IntToTest = IntToIntArray(i);
                if (CheckIfDigitsDiffer(IntToTest))
                {
                    IntMultiplied = IntToIntArray(i * 2);
                    if (CheckIfDigitsDiffer(IntMultiplied))
                    {
                        if (CheckIfArraysDiffer(IntToTest, IntMultiplied))
                        {
                            IntMultiplied = IntToIntArray(i * 3);
                            if (CheckIfDigitsDiffer(IntMultiplied))
                            {
                                if (CheckIfArraysDiffer(IntToTest, IntMultiplied))
                                {
                                    IntMultiplied = IntToIntArray(i * 4);
                                    if (CheckIfDigitsDiffer(IntMultiplied))
                                    {
                                        if (CheckIfArraysDiffer(IntToTest, IntMultiplied))
                                        {
                                            IntMultiplied = IntToIntArray(i * 5);
                                            if (CheckIfDigitsDiffer(IntMultiplied))
                                            {
                                                if (CheckIfArraysDiffer(IntToTest, IntMultiplied))
                                                {
                                                    IntMultiplied = IntToIntArray(i * 6);
                                                    if (CheckIfDigitsDiffer(IntMultiplied))
                                                    {
                                                        if (CheckIfArraysDiffer(IntToTest, IntMultiplied))
                                                        {
                                                            Console.WriteLine($"Radau magija {i}"); // Jovalas, but does the job ;D
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

            Console.ReadKey();
        }


        static int[] IntToIntArray(int Integer)
        {
            string IntStringified = Integer.ToString();
            int[] IntArrToReturn = new int[IntStringified.Length];
            for (int i = 0; i < IntArrToReturn.Length; i++)
            {
                IntArrToReturn[i] = Convert.ToInt32(IntStringified[i]);
            }
            return IntArrToReturn;
        }

        static bool CheckIfDigitsDiffer(int[] ArrayPassed)
        {
            int[] ArrayToCheck = new int[ArrayPassed.Length];
            ArrayPassed.CopyTo(ArrayToCheck, 0);
            int count = 0;

            for (int i = 0; i < ArrayToCheck.Length; i++)
            {
                count = 0;
                for (int j = 0; j < ArrayToCheck.Length; j++)
                {
                    if (count != 2)
                    {
                        if (ArrayToCheck[i] == ArrayToCheck[j]) count++;
                    }
                    else return false;
                }
            }
            return true;
        }

        static bool CheckIfArraysDiffer(int[] arr1, int[] arr2)
        {
            int[] ArrayToCheck1 = new int[arr1.Length]; arr1.CopyTo(ArrayToCheck1, 0);
            int[] ArrayToCheck2 = new int[arr2.Length]; arr2.CopyTo(ArrayToCheck2, 0);

            Array.Sort(ArrayToCheck1);
            Array.Sort(ArrayToCheck2);

            if (ArrayToCheck1.Length != ArrayToCheck2.Length) return false;

            for (int i = 0; i < ArrayToCheck1.Length; i++)
            {
                if (ArrayToCheck1[i] != ArrayToCheck2[i]) return false;
            }
            return true;
        }
    }
}
