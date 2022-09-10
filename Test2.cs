using System.Text.RegularExpressions;

class GuessTheSecretNumber
{
    private static void Main()
    {
        Console.WriteLine("Hello there, guess the secret number!");

        //Regex to validate that input is an integer number
        Regex isValidNumber = new Regex(@"[0-9]");

        //Declaration of the secret number
        int secretNumber = 1;

        List<int> listOfGuessedNumbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Enter your guess...");

            var input = Console.ReadLine() ?? "";


            try
            {
                if (isValidNumber.IsMatch(input))
                {
                    int guessedNumber = (int)int.Parse(input);

                    if (guessedNumber == secretNumber)
                    {
                        listOfGuessedNumbers.Add(guessedNumber);

                        string successMessage = listOfGuessedNumbers.Count == 1 ? "You guessed once" : $"You guessed {listOfGuessedNumbers.Count} times";

                        Console.WriteLine($"Your guess ({guessedNumber}) was correct!");
                        Console.WriteLine(successMessage);

                        break;
                    }

                    string failureMessage = guessedNumber > secretNumber ? $"Your guess ({guessedNumber}) was too large" : $"Your guess ({guessedNumber}) was too small";

                    Console.WriteLine(failureMessage + ", try again");
                    Console.WriteLine('\n');

                    if (!listOfGuessedNumbers.Contains(guessedNumber))
                    {
                        listOfGuessedNumbers.Add(guessedNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Your guess must be an integer number");
                    Console.WriteLine('\n');
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Input must be an integer number");
                Console.WriteLine('\n');
            }
        }
    }
}
