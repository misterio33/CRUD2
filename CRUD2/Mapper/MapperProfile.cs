using AutoMapper;
using CRUD2.Entities;
using CRUD2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD2.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<NewBlogPostViewModel, BlogPost>();
        }
    }
}
