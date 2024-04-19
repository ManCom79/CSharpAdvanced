using Serilog;

namespace CalculationApp_with_Logging_Enabled
{
    public class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Exercise";
            string filePath = $@"{folderPath}\calculations.txt";

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(@"C:\Exercise\logs-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(@"C:\Exercise");
                Log.Information(@"Folder ""C:\Exercise"" created.");
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
                Log.Information("Entering the first number!");
                string number1 = Console.ReadLine();

                if (!int.TryParse(number1, out sumNumber1))
                {
                    Console.WriteLine("The entered value was not numeric!");
                    Log.Error("The entered value was not numeric!");
                    continue;
                }
                Log.Information($"First logged number is {sumNumber1}");

                while (true)
                {
                    Console.Write("Please enter the second number: ");
                    Log.Information("Entering the second number!");
                    string number2 = Console.ReadLine();

                    if (!int.TryParse(number2, out sumNumber2))
                    {
                        Console.WriteLine("The entered value was not numeric!");
                        Log.Error("The entered value was not numeric!");
                        continue;
                    }
                    Log.Information($"Second logged number is {sumNumber1}");
                    break;
                }

                string resultOfCalculation = CalulateSum(sumNumber1, sumNumber2);

                Console.WriteLine(resultOfCalculation);

                using(var inFileCalculation = new StreamWriter(filePath, true))
                {
                    inFileCalculation.WriteLine($"[{DateTime.Now}] {resultOfCalculation}");
                    Log.Information($"Written to file is: [{DateTime.Now}] {resultOfCalculation}");
                }

                counter++;
            }
        }

        public static string CalulateSum(int a, int b)
        {
            Log.Information("Function 'CalculateSum is calculating...'");
            int result = a + b;
            return $"{a} + {b} = {result}";
        }
    }
}
