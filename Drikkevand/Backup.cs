using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drikkevand
{
    internal class Backup
    {
        //        public void GetFile()
        //        {
        //            string rootPath = @"C:\Users\df\Desktop\json";

        //            string[] files = Directory.GetFiles(rootPath);

        //            // Display the list of files to the user
        //            for (int i = 0; i < files.Length; i++)
        //            {
        //                Console.WriteLine($"{i + 1}: {files[i]}");
        //            }

        //            // Prompt the user to select a file
        //            Console.Write("Vælg en fil ud for nummer: ");
        //            string userInput = Console.ReadLine();

        //            if (int.TryParse(userInput, out int selectedFileIndex) && selectedFileIndex > 0 && selectedFileIndex <= files.Length)
        //            {
        //                string selectedFilePath = files[selectedFileIndex - 1];

        //                // Read JSON content from the selected file
        //                string jsonContent = File.ReadAllText(selectedFilePath);

        //                try
        //                {
        //                    // Parse JSON using Json.NET and deserialize it into a list of QuizQuestion objects
        //                    List<QuizQuestion> quizQuestions = JsonConvert.DeserializeObject<List<QuizQuestion>>(jsonContent);

        //                    // Loop through each question
        //                    foreach (var question in quizQuestions)
        //                    {
        //                        bool correctAnswer = false;

        //                        do
        //                        {
        //                            Console.WriteLine($"Spørgsmål {question.Number}: {question.Question}");

        //                            // Display answer options
        //                            for (int i = 0; i < question.Answers.Count; i++)
        //                            {
        //                                Console.WriteLine($"{i + 1}: {question.Answers[i]}");
        //                            }

        //                            // Prompt user for an answer
        //                            Console.Write("Vælg et svar ud for nummer: ");
        //                            string userAnswer = Console.ReadLine();

        //                            if (int.TryParse(userAnswer, out int selectedAnswerIndex) &&
        //                                selectedAnswerIndex > 0 && selectedAnswerIndex <= question.Answers.Count)
        //                            {
        //                                // Check if the user's answer is correct (case-insensitive)
        //                                correctAnswer = string.Equals(question.Answers[selectedAnswerIndex - 1], question.CorrectAnswer, StringComparison.OrdinalIgnoreCase);

        //                                if (correctAnswer)
        //                                {
        //                                    Console.WriteLine($"{question.IsCorrect[0]}. Info: {question.Info}");
        //                                }
        //                                else
        //                                {
        //                                    Console.Clear();
        //                                    Console.WriteLine($"{question.IsCorrect[1]} Prøv igen!");
        //                                }
        //                            }
        //                            else
        //                            {
        //                                Console.WriteLine("Ugyldigt input, prøv igen!");
        //                            }
        //                        } while (!correctAnswer);

        //                        Console.WriteLine();
        //                    }
        //                }
        //                catch (JsonException ex)
        //                {
        //                    Console.WriteLine("Fejl med parsing JSON: " + ex.Message);
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Ugyldigt valg. Vælg et gyldigt fil nummer.");
        //            }

        //            Console.ReadLine();
        //        }
        //    }
        //}
    }
}