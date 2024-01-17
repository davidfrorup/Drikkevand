namespace Drikkevand
{
    public class Score
    {

        public int userScore { get; set; } = 0;

        public void Percentage()
        {
            double percentage = (double)userScore / TheQuiz.quizQuestions.Count * 100;
            Console.WriteLine($"\nDu har svaret rigtigt på {userScore} ud af {TheQuiz.quizQuestions.Count} spørgsmål. ({percentage}% korrekte)");
        }

    }
}
