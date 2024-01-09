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

            int userScore = 0;

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

                    string jsonContent = File.ReadAllText(selectedFilePath);

                    List<QuizQuestions> quizQuestions = JsonConvert.DeserializeObject<List<QuizQuestions>>(jsonContent);

                    Console.Clear();

                    foreach (QuizQuestions question in quizQuestions)
                    {


                        Console.WriteLine($"Spørgsmål {question.Number}: {question.Question}");


                        for (int i = 0; i < question.Answers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}: {question.Answers[i]}");
                        }

                        Console.Write("Vælg et svar ud for nummer: ");
                        string userAnswer = Console.ReadLine();


                        if (userAnswer == question.CorrectAnswer)
                        {
                            Console.WriteLine($"\n{question.IsCorrect[0]} \n\nInfo: {question.Info}");
                            Console.WriteLine("\nTryk vilkårlig tast for at fortsætte.");
                            Console.ReadKey();
                            Console.Clear();
                            userScore++;
                        }
                        else
                        {
                            Console.WriteLine($"\n{question.IsCorrect[1]} \n\nInfo: {question.Info}");
                            Console.WriteLine("\nTryk vilkårlig tast for at fortsætte.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }
                    double percentage = (double)userScore / quizQuestions.Count * 100;
                    Console.WriteLine($"\nDu har svaret rigtigt på {userScore} ud af {quizQuestions.Count} spørgsmål. ({percentage}% korrekte)");
                    
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

