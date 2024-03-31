using Services;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1, "Bob", "Bobsky", 35);
            User user2 = new User(2, "Jane", "Doe", 37);
            User user3 = new User(3, "John", "Doe", 33);
            User user4 = new User(4, "Ana", "Enson", 40);
            User user5 = new User(5, "Rick", "Johnson", 40);

            UserDatabase.AddUser(user1);
            UserDatabase.AddUser(user2);
            UserDatabase.AddUser(user3);
            UserDatabase.AddUser(user4);
            UserDatabase.AddUser(user5);

            while (true)
            {
                Console.WriteLine("\nSearch user(s) by:\n1) ID\n2) Name\n3) Age");
                string selectedSearchMode = Console.ReadLine();
                switch (selectedSearchMode)
                {
                    case "1":
                        {
                            validateEnteredId();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Please enter a name: ");
                            string inputName = Console.ReadLine();
                            UserDatabase.SearchUser(inputName);
                            break;
                        }
                    case "3":
                        {
                            validateEnteredAge();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please entere 1, 2 or 3");
                            continue;
                        }
                }
            };
        }

        public static void validateEnteredId()
        {
            while (true)
            {
                Console.Write("Please enter ID: ");
                string inputId = Console.ReadLine();

                if (int.TryParse(inputId, out int id))
                {
                    Console.WriteLine(UserDatabase.SearchUser(id, "id"));
                } else { 
                    Console.WriteLine("Please enter a number!");
                }
                break;
            }
        }

        public static void validateEnteredAge()
        {
            while (true)
            {
                Console.Write("Please enter Age: ");
                string inputAge = Console.ReadLine();

                if (int.TryParse(inputAge, out int age))
                {
                    Console.WriteLine(UserDatabase.SearchUser(age, "age"));
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
                break;
            }
        }
    }
}
