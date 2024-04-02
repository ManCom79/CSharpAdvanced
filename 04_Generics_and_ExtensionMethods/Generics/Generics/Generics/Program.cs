namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            double doubleNumber = 2.0;
            char character = 'a';
            string words = "Generic String";

            int[] integers = { 1, 2, 3, 4, 5 };
            string[] integerStrigs = { "one", "two", "three", "four", "five" };

            PrintConsole.Print(number);
            PrintConsole.Print(doubleNumber);
            PrintConsole.Print(character);
            PrintConsole.Print(words);

            PrintConsole.PrintCollection(integers);
            PrintConsole.PrintCollection(integerStrigs);
            
        }
    }
}
