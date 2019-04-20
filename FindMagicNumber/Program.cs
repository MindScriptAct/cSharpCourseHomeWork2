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
            // Magic Number
            int magicNumber = 0;
            int multipliedNumber = 0;

            // sukurti pirmą tuščią masyvą
            int[] myArray1 = new int[6];


            // sukurti atsitiktinių skaičių generatorių
            Random random = new Random();

            
            // patikrinti ar nėra dublikatų ir ar skaičius padauginus netapo per didelis
            while (NumbersDublicate(myArray1) == true || NumberTooBig(multipliedNumber) == true)
            {
                // atsitiktinis sveikasis skaičius
                int randomNumber = random.Next(100000, 999999);


                // atsitiktinį sveikąjį skaičių išskaidyti į masyvą
                // ats. svk. skč. paverstas į eilutė, kad galima būtų išskaidyti į masyvą
                string random_NrToString = ConvertToString(randomNumber);

                // eilutė išskaidyta į masyvą
                AddToArray(random_NrToString, myArray1);

                // jeigu dublikuojasi skaitmenys pradėti ciklą iš naujo
                if (NumbersDublicate(myArray1) == true)
                {
                    continue;
                }


                // patikrina ar skaičius ne per didelis
                // tikėtinas magiškas skaičius
                magicNumber = ConvertToInt(myArray1);

                // mag. skč. padaugintas iš dviejų
                multipliedNumber = magicNumber * 2;

                // jeigu per didelis skaičius pradėti ciklą iš naujo
                if (NumberTooBig(multipliedNumber) == true)
                {
                    continue;
                }


                // sukurti antrą masyvą palyginimui
                    int[] myArray2 = new int[6];


                // padaugintą sveikąjį skaičių išskaidyti į masyvą
                // pad. svk. skč. paverstas į eilutė, kad galima būtų išskaidyti į masyvą
                string multiplied_NrToString = ConvertToString(multipliedNumber);

                // eilutė išskaidyta į masyvą
                AddToArray(multiplied_NrToString, myArray2);


                // palyginti masyvus
                bool foundSameNr = false;
                for (int i = 0; i < myArray1.Length; i++)
                {


                    for (int j = 0; j < myArray2.Length; j++)
                    {


                        if (myArray1[i] == myArray2[j])
                        {
                            foundSameNr = true;
                            Console.WriteLine($"Masyve1 skaičius {myArray1[i]} buvo rastas Masyve2");
                        }
                    }


                    if (foundSameNr == false)
                    {
                        Console.WriteLine($"Masyve1 skaičius {myArray1[i]} nebuvo rastas Masyve2");
                    }


                    foundSameNr = false;
                }
            }

            Console.WriteLine($"mano padaugintas skaicius {multipliedNumber}");
            Console.WriteLine($"mano skaicius {magicNumber}");
            
            Console.ReadKey();
        }

        static string ConvertToString(int number)
        {
            return (Convert.ToString(number));
        }

        static void AddToArray(string NrToString, int[] myArray)
        {
            for (int i = 0; i < NrToString.Length; i++)
            {
                myArray[i] = NrToString[i] - '0'; // <- kas yra '0'?
            }
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
    }
}
