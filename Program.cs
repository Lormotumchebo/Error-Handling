using static Error_Handling.Age;
using static Error_Handling.Numbers;


    {
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
