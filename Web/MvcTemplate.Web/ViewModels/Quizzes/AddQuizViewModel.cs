namespace MvcTemplate.Web.ViewModels.Quizzes
{
    using AutoMapper;
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;
    using System.Collections.Generic;

    public class AddQuizViewModel : IMapFrom<Quiz>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public int CategoryID { get; set; }

        public virtual QuizCategory QuizCategory { get; set; }

        public ICollection<QuizCategory> QuizCategories { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Quiz, AddQuizViewModel>()
                .ForMember(x => x.QuizCategory, opt => opt.MapFrom(x => x.QuizCategory.Name));
        }
    }
}