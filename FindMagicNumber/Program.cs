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


            Console.WriteLine("Hello\n");

            for (int i = 100000; i < 1000000; i++)
            {

                int TryNumber = i;
                int[] TryNumberInArray = IntToIntArray(TryNumber);


                if (AllNumbersDifferent(TryNumberInArray))
                {
                    if (
                        CompareTwoArraysSameValueElements(TryNumberInArray, IntToIntArray(TryNumber * 2))
                        && CompareTwoArraysSameValueElements(TryNumberInArray, IntToIntArray(TryNumber * 3))
                        && CompareTwoArraysSameValueElements(TryNumberInArray, IntToIntArray(TryNumber * 4))
                        && CompareTwoArraysSameValueElements(TryNumberInArray, IntToIntArray(TryNumber * 5))
                        && CompareTwoArraysSameValueElements(TryNumberInArray, IntToIntArray(TryNumber * 6))
                        )
                    {
                        Console.WriteLine("Congratulations MAGIC NUMBER IS: {0}", TryNumber);
                    }
                }
            }

            Console.WriteLine("\nGood Bye");
            Console.ReadLine();

            // FUNCTIONS


        }
        static bool AllNumbersDifferent(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {

                        return false;

                    }
                }
            }

            return true; ;


        }

        static int[] IntToIntArray(int x)
        {
            int[] arr = new int[6];

            arr[0] = x / 100000;
            arr[1] = x / 10000 % 10;
            arr[2] = x / 1000 % 10;
            arr[3] = x / 100 % 10;
            arr[4] = x / 10 % 10;
            arr[5] = x % 10;

            return arr;
        }

        static bool CompareTwoArraysSameValueElements(int[] arr1, int[] arr2)
        {
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        sum += 1;
                    }

                }
            }
            if (sum == 6)
            {
                return true;
            }

            return false;
        }
    }
}

