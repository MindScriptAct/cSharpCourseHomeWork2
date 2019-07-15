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

            for (int i = 123456; i < 166666; i++)
            {

                int TryNumber = i;


                int[] TryNumberInArray = IntToIntArray(TryNumber);

                if (AllNumbersDifferent(TryNumberInArray))
                {
                    int[] MultipliedNumberInArray_by2 = IntToIntArray(Multiplication(TryNumber, 2));
                    int[] MultipliedNumberInArray_by3 = IntToIntArray(Multiplication(TryNumber, 3));
                    int[] MultipliedNumberInArray_by4 = IntToIntArray(Multiplication(TryNumber, 4));
                    int[] MultipliedNumberInArray_by5 = IntToIntArray(Multiplication(TryNumber, 5));
                    int[] MultipliedNumberInArray_by6 = IntToIntArray(Multiplication(TryNumber, 6));


                    if (
                           AllNumbersDifferent(MultipliedNumberInArray_by2)
                        && AllNumbersDifferent(MultipliedNumberInArray_by3)
                        && AllNumbersDifferent(MultipliedNumberInArray_by4)
                        && AllNumbersDifferent(MultipliedNumberInArray_by5)
                        && AllNumbersDifferent(MultipliedNumberInArray_by6)
                        )
                    {

                        if (CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray_by2)
                            && CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray_by3)
                            && CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray_by4)
                            && CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray_by5)
                            && CompareTwoArraysNotSamePositionElements(TryNumberInArray, MultipliedNumberInArray_by6)
                            )
                        {
                            if (CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray_by2)
                                && CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray_by3)
                                && CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray_by4)
                                && CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray_by5)
                                && CompareTwoArraysSameValueElements(TryNumberInArray, MultipliedNumberInArray_by6)
                                )
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

