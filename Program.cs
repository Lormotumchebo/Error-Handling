using static Error_Handling.Age;
using static Error_Handling.Files;
using static Error_Handling.Input;
using static Error_Handling.Numbers;


   /* {
        try
        {
            (int numerator, int denominator) = NumberOperations.GetValidInput(); 

            int result = NumberOperations.Divide(numerator, denominator); 

            Console.WriteLine($"The result of {numerator} / {denominator} is: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero. Please enter a non-zero denominator.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The numbers are too large to calculate.");
        }
        finally
        {
            Console.WriteLine("Division operation complete.");
        }

        Console.ReadKey();
    }


    {
        try
        {
            Console.Write("Enter the person's age: ");
            string ageInput = Console.ReadLine();
            int age;

            if (!int.TryParse(ageInput, out age)) 
            {
                throw new FormatException("Invalid input. Please enter an integer.");
            }

            Person person = new Person(age); 
            Console.WriteLine($"Person's age: {person.Age}");

        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}"); // Catch and display the custom exception message
        }
        catch (FormatException ex) // Catch FormatException for non-integer inputs
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)  // Catch any other exceptions (good practice)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.ReadKey();
    }


    {
        try
        {
            int number = InputValidator.GetValidIntegerInput(); // Get valid input from the user.

            Console.WriteLine($"You entered: {number}"); // Display the number

        }
        catch (OverflowException) // Catch OverflowException for numbers too large/small (less likely now)
        {
            Console.WriteLine("The number is too large or too small. Please enter a number within the valid range for an integer.");
        }
        catch (Exception ex) // Catch any other exceptions (good practice)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.ReadKey(); // Keep the console window open
    }

*/
    {
        string filePath = "my_file.txt";

        try
        {
            // Method 1: Read all lines
            string[] lines = FileReader.ReadAllLines(filePath);
            Console.WriteLine("File content (Method 1):");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // Method 2: Read line by line
            Console.WriteLine("\nFile content (Method 2):");
            FileReader.ReadLineByLine(filePath);


        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{filePath}' was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("File reading operation complete.");
        }

        Console.ReadKey();
    }
