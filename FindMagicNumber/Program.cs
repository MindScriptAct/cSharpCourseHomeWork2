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

            int multiplication = 2;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numbers devided by: {0}", multiplication);

                for (int j = 123456; j < 166666; j++)
                {

                    int TryNumber = j;
                    

                    int[] TryNumberInArray = IntToIntArray(TryNumber);

                    if (AllNumbersDifferent(TryNumberInArray))
                    {
                        int[] MultipliedNumberInArray = IntToIntArray(Multiplication(TryNumber, multiplication));

                        if (AllNumbersDifferent(MultipliedNumberInArray))
                        {
                            if (CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray))
                            {
                                if (CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray))
                                {
                                    Congratulations(TryNumber);


                                }
                            }
                            else
                            {
                                //Console.WriteLine("Some of the two comparing ARRAY elements are in the same position");
                            }

                        }
                        else
                        {
                            //Console.WriteLine("After multiplication number is larger than 6 elements,\n or not all numbers are different");
                        }
                    }
                    else
                    {
                        //Console.WriteLine("Your number is not with different int's");
                    }

                }

                multiplication++;
            }
            Console.ReadKey();

        }

        // FUNCTIONS

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

        static int Multiplication(int x, int mulipl)
        {
            return x * mulipl;

        }

        static bool CompareTwoArraysNotSamePositionElements(int[] arr1, int[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].Equals(arr2[i]))
                    {
                        return false;
                    }
                }

            }

            return true;

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

        static void Congratulations(int x)
        {
            Console.WriteLine("Congratulations MAGIC NUMBER IS: {0}", x);
        }
    }
}
