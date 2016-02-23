namespace MvcTemplate.Data.Models
{
    using System.Collections.Generic;

    public class QuizCategory
    {
        public string Name { get; set; }

        public virtual ICollection<Quiz> quizzes { get; set; }
    }
}
