using System;

/*
    Created by Jesper Henriksen
    Date 24-02-2018

    Problem - Find Pi to the Nth Digit, within a set limit.

    Logic:
    1. Define Pi
    2. Get amount of digits to show
    3. validate input is a digit and lower than 15
    4. show value of pi with amount of digits.
*/

namespace KaranFindPiToNthDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            // Gets user input for the amount of digits.
            Console.Write("Please input the amount of digits you want: ");
            string input = Console.ReadLine();
            int inputInt = 0;

            //Implemented error handling in case of input being anything but int.
            try
            {
                inputInt = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //Validates input to be a whole number
            
            if (inputInt <= 14)
            {
                string PiString = Pi.ToString();
                PiString = PiString.Substring(0, PiString.Length - (14 - inputInt));
                Console.WriteLine(PiString);

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Number higher than allowed 14 digits. Please retry.");
                Console.ReadKey();
            }
        }
    }
}
