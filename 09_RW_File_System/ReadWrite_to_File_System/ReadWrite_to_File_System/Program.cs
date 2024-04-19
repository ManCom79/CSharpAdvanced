namespace ReadWrite_to_File_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Files";
            string filePath = $@"{folderPath}\names.txt";

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine(@"Creating folder C:\Files");
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine($@"Creating file names.txt at {filePath}");
                var file = File.Create(filePath);
                file.Close();

            }

            using (var streamReader =  new StreamReader(filePath))
            {
                var fileNamesContent = streamReader.ReadToEnd();
            }

            List<string> names = new List<string>();
            int count = 0;

            while (count < 3)
            {
                Console.WriteLine("Please enter a name");
                string name = Console.ReadLine();
                names.Add(name);
                count++;
            }

            using (var streamWrite = new StreamWriter(filePath))
            {
                foreach (string name in names)
                {
                    streamWrite.WriteLine(name);
                }
                Console.WriteLine($"All names are written at {folderPath}.");
            }
        }
    }
}
