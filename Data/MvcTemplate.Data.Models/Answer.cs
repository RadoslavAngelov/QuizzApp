namespace MvcTemplate.Data.Models
{
    using MvcTemplate.Data.Common.Models;

    public class Answer : BaseModel<int>
    {
        public string Content { get; set; }

        public int QuestionID { get; set; }

        public IsCorrectEnumeration IsCorrect { get; set; }

        public virtual Question Question { get; set; }
    }
}
