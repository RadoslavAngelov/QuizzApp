namespace MvcTemplate.Data.Models
{
    using System.Collections.Generic;

    public class Question
    {
        public string Content { get; set; }

        public int QuizID { get; set; }

        public virtual Quiz Quiz { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
