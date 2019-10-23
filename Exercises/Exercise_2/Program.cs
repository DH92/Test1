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
            //  decimalNum = Convert.ToInt32(Console.ReadLine());
            decimalNum = 16;
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
            int hex = dec;



            if (hex % 6 == 0)
            {
                hex = hex % 6;
                return hex;
            }
            else
            {
                hex = hex % 6;
                return ConvertDecimalToHexal(hex);


            }


        }

    }
}



