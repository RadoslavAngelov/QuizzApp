namespace MvcTemplate.Data.Models
{
    using MvcTemplate.Data.Common.Models;

    public class Quiz : BaseModel<int>
    {
        public string Title { get; set; }

        public int CategoryID { get; set; }

        public virtual QuizCategory QuizCategory { get; set; }

    }
}
