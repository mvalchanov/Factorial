using System;
using System.Numerics;

namespace nFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            Console.WriteLine("Press <Enter> or write \"end\" to exit \n");
            do
            {
                Console.Write("Insert number: ");

                inputString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputString) || inputString == "end")
                {
                    break;
                }

                bool isNumber = int.TryParse(inputString, out int parsedNumber);


                if (isNumber)
                {
                    BigInteger result = CalculateFactorial(parsedNumber);

                    Console.WriteLine($"\t {parsedNumber}! = {result} \n");

                }
                else
                {
                    Console.WriteLine("Please enter a valid number. \n");

                }

            } while (inputString != "end");

        }

        private static BigInteger CalculateFactorial(int number)
        {
            BigInteger result = 1;

            if (number == 0)
            {
                return result;
            }

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;

        }
    }
}
