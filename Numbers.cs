using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    internal class Numbers
    {
        

public class NumberOperations
    {
        public static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public static (int numerator, int denominator) GetValidInput()
        {
            int numerator;
            string numeratorInput;
            do
            {
                Console.Write("Enter the numerator: ");
                numeratorInput = Console.ReadLine();
            } while (!int.TryParse(numeratorInput, out numerator));


            int denominator;
            string denominatorInput;
            do
            {
                Console.Write("Enter the denominator: ");
                denominatorInput = Console.ReadLine();
            } while (!int.TryParse(denominatorInput, out denominator));

            return (numerator, denominator);
        }
    }

   
}
}
