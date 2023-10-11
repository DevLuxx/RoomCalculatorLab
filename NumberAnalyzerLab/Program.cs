namespace NumberAnalyzerLab
{
    internal class Program
    {
        static void Main()
        {

            bool validInput = false;

            do

            {
                Console.Write("Please enter a number between 1 and 100: ");

                string userNumInput = Console.ReadLine();

                if (int.TryParse(userNumInput, out int userInput) && userInput >= 1 && userInput <= 100)
                {
                    if (userInput % 2 != 0 && userInput < 60)
                    {
                        Console.WriteLine($"You entered: {userInput}");
                        Console.WriteLine($"This number is odd and less than 60.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 24)
                    {
                        Console.WriteLine($"You entered: {userInput}");
                        Console.WriteLine($"This number is even and less than 25.");
                    }
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine($"You entered: {userInput}");
                        Console.WriteLine($"This number is even and between 26 and 60.");
                    }
                    else if (userInput % 2 == 0 && userInput > 60)
                    {
                        Console.WriteLine($"You entered: {userInput}");
                        Console.WriteLine($"This number is even and greater than 60.");
                    }
                    else if (userInput % 2 != 0 && userInput > 60)
                    {
                        Console.WriteLine($"You entered: {userInput}");
                        Console.WriteLine($"This number is odd and greater than 60.");
                    }

                    validInput = true;

                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            } while (!validInput);
        }

    }
}