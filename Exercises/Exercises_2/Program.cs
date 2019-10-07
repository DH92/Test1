using System;

namespace Exercises_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int decimalNum;
        Start:

            Console.WriteLine("Enter a number between 0 and 1023: ");
            decimalNum = Convert.ToInt32(Console.ReadLine());
            if (decimalNum >= 0 && decimalNum <= 1023)
            {
                Console.WriteLine(ConvertDecimalToHexal(decimalNum));
            }
            else if (decimalNum > 1023)
            {
                Console.WriteLine("Number must be lower than 1023");
                goto Start;
            }
            else if (decimalNum < 0)
            {
                Console.WriteLine("Number must be higher than 0");
                goto Start;
            }
        }

        static int ConvertDecimalToHexal(int dec)
        {
            int modulo = dec;
            int hex;
            string convertedDecString = "";





            modulo = dec %= 6;
            Console.WriteLine("NumFirst: " + modulo);
            convertedDecString.Insert(0, modulo.ToString());
            if (modulo % 6 == 0)
            {

                modulo = modulo %= 6;
                Console.WriteLine("End: " + modulo);
                convertedDecString.Insert(0, modulo.ToString());

            }
            else
            {
                modulo = modulo %= 6;
                Console.WriteLine("Again: " + modulo);
            }
            // Int32.TryParse(convertedDecString, out hex);

            return modulo;
        }

    }
}



