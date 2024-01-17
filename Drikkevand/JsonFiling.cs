using Newtonsoft.Json;

namespace Drikkevand
{
    public class JsonFiling
    {

        public static List<QuizQuestions> Jsoning()
        {

            string selectedFilePath = FindFile.GetFile();

            string jsonContent = File.ReadAllText(selectedFilePath);
            Console.Clear();

            return JsonConvert.DeserializeObject<List<QuizQuestions>>(jsonContent);

        }

    }

}
