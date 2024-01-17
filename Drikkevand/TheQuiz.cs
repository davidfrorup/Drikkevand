namespace Drikkevand
{
    public class TheQuiz
    {
        public static List<QuizQuestions> quizQuestions = JsonFiling.Jsoning();
        public static void Quuuiz()
        {
            Score player = new();

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
                    player.userScore++;
                }
                else
                {
                    Console.WriteLine($"\n{question.IsCorrect[1]} \n\nInfo: {question.Info}");
                    Console.WriteLine("\nTryk vilkårlig tast for at fortsætte.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            player.Percentage();

        }
    }
}
