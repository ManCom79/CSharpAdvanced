namespace PrintConsole
{
    public class PrintConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine($"The value added to be printed is \"{item}\"");
        }

        public static void PrintCollection(string message) 
        {

        }
    }
}
