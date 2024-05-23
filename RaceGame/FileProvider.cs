using System.Text;

namespace Race
{
    public class FileProvider
    {
        public static void Replace(string fileName, string line)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(line);
            writer.Close();
        }

        public static string Read(string fileName)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.UTF8);

            string lines = reader.ReadToEnd();
            reader.Close();

            return lines;
        }

        public static bool IsExists(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
