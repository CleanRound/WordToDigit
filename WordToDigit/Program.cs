internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> wordToDigit = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        Console.Write("Enter a word representing a digit: ");
        string word = Console.ReadLine().ToLower();

        if (wordToDigit.ContainsKey(word))
        {
            int number = wordToDigit[word];
            Console.WriteLine($"The corresponding digit is: {number}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a word representing a digit (zero to nine).");
        }
    }
}