namespace Drikkevand
{
    public class QuizQuestions
    {
        public string Number { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IsCorrect { get; set; }
        public string Info { get; set; }
    }
}
