namespace MvcTemplate.Data.Models
{
    using Common.Models;
    using System.Collections.Generic;

    public class QuizCategory : BaseModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Quiz> quizzes { get; set; }
    }
}
