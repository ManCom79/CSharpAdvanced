using Services;
using System.Reflection.Metadata;

namespace _02_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This text will be provided to both Docum and Webpage classess. The ingerited method from the interface will search if specific word is present in this text.";
            
            Docum doc = new Docum(text);
            Webpage web = new Webpage(text);

            Console.WriteLine(doc.Search("william"));
            Console.WriteLine(doc.Search("will"));
            Console.WriteLine(web.Search("william"));
            Console.WriteLine(web.Search("will"));

        }
    }
}
