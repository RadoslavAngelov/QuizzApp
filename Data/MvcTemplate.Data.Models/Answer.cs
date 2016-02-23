namespace MvcTemplate.Data.Models
{
    public class Answer
    {
        public string Content { get; set; }

        public int QuestionID { get; set; }

        public IsCorrectEnumeration IsCorrect { get; set; }

        public virtual Question Question { get; set; }
    }
}
