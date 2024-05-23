using Newtonsoft.Json;

namespace Race
{
    public static class UsersResults
    {
        public static string fileName = "userResults.json";

        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.IsExists(fileName))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Read(fileName);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }

        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(fileName, jsonData);
        }
    }
}
