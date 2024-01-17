

namespace Drikkevand
{
    public class FindFile
    {
        public static string GetFile()
        {

            string rootPath = @"C:\Users\df\Desktop\json";

            string[] files = Directory.GetFiles(rootPath);

            do
            {
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {files[i]}");
                }

                Console.Write("Vælg en fil ud for nummer: ");

                if (int.TryParse(Console.ReadLine(), out int selectedFileIndex) && selectedFileIndex > 0 && selectedFileIndex <= files.Length)
                {
                    return files[selectedFileIndex - 1];
                }

                else
                {
                    Console.WriteLine("Ugyldigt valg. Vælg et gyldigt fil nummer.");
                }

            } while (true);
        }
    }
}

