namespace CalculationApp_with_Logging_Enabled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Exercise";
            string filePath = $@"{folderPath}\calculations.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(@"C:\Exercise");
            }

            if (!File.Exists(filePath))
            { 
                File.Create(filePath);
            }

            int counter = 1;
            int sumNumber1;
            int sumNumber2;

            while (counter < 4)
            {
                Console.WriteLine($"Call {counter}:");
                Console.Write("Please enter the first number: ");
                string number1 = Console.ReadLine();

                if (!int.TryParse(number1, out sumNumber1))
                {
                    Console.WriteLine("The entered value was not numeric!");
                    continue;
                }

                while (true)
                {
                    Console.Write("Please enter the second number: ");
                    string number2 = Console.ReadLine();

                    if (!int.TryParse(number2, out sumNumber2))
                    {
                        Console.WriteLine("The entered value was not numeric!");
                        continue;
                    }
                    break;
                }

                string resultOfCalculation = CalulateSum(sumNumber1, sumNumber2);

                Console.WriteLine(resultOfCalculation);

                using(var inFileCalculation = new StreamWriter(filePath, true))
                {
                    inFileCalculation.WriteLine($"[{DateTime.Now}] {resultOfCalculation}");
                }

                counter++;
            }
        }

        public static string CalulateSum(int a, int b)
        {
            int result = a + b;
            return $"{a} + {b} = {result}";
        }
    }
}
