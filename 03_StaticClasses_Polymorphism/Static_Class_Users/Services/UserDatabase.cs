namespace Services
{
    public static class UserDatabase
    {
        public static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            users.Add(user);
        }
        public static void RemoveUser(User user)
        {
            users.Add(user);
        }
        public static string SearchUser(int number, string idOrAge)
        {
            if (idOrAge == "id")
            {
                List<User> userFound = users.Where(x => x.Id == number).ToList();
                if (userFound.Count > 0)
                {
                    return $"Found user:\nUserID: {userFound[0].Id}; Name: {userFound[0].FirstName} {userFound[0].LastName}";
                }
                else
                {
                    return $"The user with Id: {number} does not exist.";
                }
            } else if (idOrAge == "age")
            {
                List<User> userFound = users.Where(x => x.Age == number).ToList();
                if (userFound.Count > 0)
                {
                    foreach (User user in userFound)
                    {
                        Console.WriteLine($"\nUserID: {user.Id};\nName: {user.FirstName} {user.LastName}");
                    }
                }
                else
                {
                    return $"Users with age {number} do not exist in the list.";
                }
            }
            return null;
        }

        public static string SearchUser(string name)
        {
            List<User> userFound = users.Where(x => x.FirstName == name || x.LastName == name).ToList();
            Console.WriteLine($"User(s) found with name {name}: {userFound.Count}");
            if (userFound.Count > 0)
            {
                foreach (User user in userFound)
                {

                    Console.WriteLine($"\nUserID: {user.Id};\nName: {user.FirstName} {user.LastName}");
                }
            }
            else
            {
                return $"The user with name: {name} does not exist.";
            }

            return null;
        }
    }
}
