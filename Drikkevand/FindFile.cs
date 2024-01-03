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

            // Display the list of files to the user
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {files[i]}");
            }

            // Prompt the user to select a file
            Console.Write("Choose a file by entering its number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int selectedFileIndex) && selectedFileIndex > 0 && selectedFileIndex <= files.Length)
            {
                string selectedFilePath = files[selectedFileIndex - 1];

                // Read JSON content from the selected file
                string jsonContent = File.ReadAllText(selectedFilePath);

                try
                {
                    // Parse JSON using Json.NET and deserialize it into a list of QuizQuestion objects
                    List<QuizQuestions> quizQuestions = JsonConvert.DeserializeObject<List<QuizQuestions>>(jsonContent);

                    // Loop through each question
                    foreach (var question in quizQuestions)
                    {
                        Console.WriteLine($"Question {question.Number}: {question.Question}");

                        // Display answer options
                        for (int i = 0; i < question.Answers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {question.Answers[i]}");
                        }

                        // Prompt user for an answer
                        Console.Write("Choose an answer by entering its number: ");
                        string userAnswer = Console.ReadLine();

                        if (int.TryParse(userAnswer, out int selectedAnswerIndex) &&
                            selectedAnswerIndex > 0 && selectedAnswerIndex <= question.Answers.Count)
                        {
                            // Check if the user's answer is correct
                            if (question.Answers[selectedAnswerIndex - 1] == question.CorrectAnswer)
                            {
                                Console.WriteLine("Correct answer! Info: " + question.Info);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect answer. Try again!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter a valid answer number.");
                        }

                        Console.WriteLine(); // Add a blank line for better readability
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine("Error while parsing JSON: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid file number.");
            }

            Console.ReadLine();
        }
    }
}
