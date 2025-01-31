using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    internal class Input
    {
        

public class InputValidator
    {
        public static int GetValidIntegerInput()
        {
            int number;
            string input;

            do
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    return number; // Return the number if parsing is successful
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            } while (true); // Continue looping indefinitely until a valid integer is entered

        }
    }

   
}
}
