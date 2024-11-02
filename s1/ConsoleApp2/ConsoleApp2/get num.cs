using System;

class Program
{
    static void Main()
    {
        int number = GetOnlyDigitsInput();
        Console.WriteLine("\nThe entered number is: " + number);
    }

    static int GetOnlyDigitsInput()
    {
        string input = "";

        Console.WriteLine("Please enter only digits. Press Enter to finish.");

        while (true)
        {
            // Read the key entered by the user
            var key = Console.ReadKey(intercept: true);

            // If Enter key is pressed, exit the loop
            if (key.Key == ConsoleKey.Enter)
                break;

            // If the key is a digit, add it to the input
            if (char.IsDigit(key.KeyChar))
            {
                input += key.KeyChar;
                Console.Write(key.KeyChar); // Display the entered digit
            }
        }

        // Convert the input string to an integer
        return int.TryParse(input, out int result) ? result : 0;
    }
}
