using AutoMapper;
using GroupChoice.Models.TaskViewModels;
namespace GroupChoice
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskViewModel, Data.Task>();
            CreateMap<Data.Task, TaskViewModel>();
        }
    }
}
