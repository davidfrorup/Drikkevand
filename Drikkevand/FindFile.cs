using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Drikkevand
{
    public class FindFile
    {
        public void GetFile()
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
            string userInput = Console.ReadLine();


            
                if (int.TryParse(userInput, out int selectedFileIndex) && selectedFileIndex > 0 && selectedFileIndex <= files.Length)
                {
                    string selectedFilePath = files[selectedFileIndex - 1];

                    // Read JSON content from the selected file
                    string jsonContent = File.ReadAllText(selectedFilePath);

                    break;
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg. Vælg et gyldigt fil nummer.");
                }
            } while (true);
        }
    }
}