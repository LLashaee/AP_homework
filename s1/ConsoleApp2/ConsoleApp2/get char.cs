using System;

class Program
{
    static void Main()
    {
        string text = GetOnlyLettersAndSymbolsInput();
        Console.WriteLine("\nThe entered text is: " + text);
    }

    static string GetOnlyLettersAndSymbolsInput()
    {
        string input = "";

        Console.WriteLine("Please enter only letters and symbols. Press Enter to finish.");

        while (true)
        {
            // Read the key entered by the user
            var key = Console.ReadKey(intercept: true);

            // If Enter key is pressed, exit the loop
            if (key.Key == ConsoleKey.Enter)
                break;

            // If the key is a letter or symbol, add it to the input
            if (!char.IsDigit(key.KeyChar))
            {
                input += key.KeyChar;
                Console.Write(key.KeyChar); // Display the entered character
            }
        }

        return input;
    }
}
