class PigLatinTranslator
{
    private static void Main()
    {
        Console.WriteLine("Hello there, enter text to be translated...");

        List<string> listOfTranslatedWords = new List<string>();

        var inputText = Console.ReadLine() ?? "";

        var inputTextArray = inputText.Split();

        foreach (var word in inputTextArray)
        {
            var firstLetterOfWord = word.Remove(1);

            var restOfWord = word.Substring(1);

            var endOfTranslatedWord = firstLetterOfWord + "a" + "y";

            var translatedWord = restOfWord + endOfTranslatedWord;

            listOfTranslatedWords.Add(translatedWord);
        }
        string translatedText = string.Join(" ", listOfTranslatedWords);

        Console.WriteLine(translatedText);
    }
}
