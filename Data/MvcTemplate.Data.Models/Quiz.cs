namespace MvcTemplate.Data.Models
{
    public class Quiz
    {
        public string Title { get; set; }

        public int CategoryID { get; set; }

        public virtual QuizCategory QuizCategory { get; set; }

    }
}
