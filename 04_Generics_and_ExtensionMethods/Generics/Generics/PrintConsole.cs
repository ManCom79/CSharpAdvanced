namespace Generics
{
    internal class PrintConsole
    {
        public static void Print<T>(T item)
        {
            Console.WriteLine($"The item passed to be printed is \"{item}\"");
        }

        public static void PrintCollection<T>(T[] items)
        {
            foreach(T item in items)
            {
                Console.WriteLine($"My name is \"{item}\" and I am just a single entry in the array.");
            }
        }

    }
}
