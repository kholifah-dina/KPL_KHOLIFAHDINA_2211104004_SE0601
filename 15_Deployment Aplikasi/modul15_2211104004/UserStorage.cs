using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace modul15_NIM
{
    public static class UserStorage
    {
        private static string filePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        public static void SaveUser(User user)
        {
            var users = LoadUsers();
            users.Add(user);
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static User FindUser(string username)
        {
            var users = LoadUsers();
            return users.Find(u => u.Username == username);
        }

        public static bool UsernameExists(string username)
        {
            var users = LoadUsers();
            return users.Exists(u => u.Username == username);
        }
    }
}
