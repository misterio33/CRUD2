using AutoMapper;
using CRUD2.Entities;
using CRUD2.ViewModels;

namespace CRUD2.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<NewBlogPostViewModel, BlogPost>();
            CreateMap<UpdateBlogPostViewModel, BlogPost>();
        }
    }
}
