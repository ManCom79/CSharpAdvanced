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
                File.Create(filePath);
            }
        }
    }
}
