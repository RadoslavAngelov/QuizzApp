namespace MvcTemplate.Data.Models
{
    using Common.Models;
    using System.Collections.Generic;


    public class Question : BaseModel<int>
    {
        public string Content { get; set; }

        public int QuizID { get; set; }

        public virtual Quiz Quiz { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
