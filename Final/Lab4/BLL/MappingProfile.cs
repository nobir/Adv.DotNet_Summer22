using AutoMapper;
using BLL.BOs;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<News, NewsModel>(); // It's not working because of order such as NewsModel to News not News to NewsModel

            CreateMap<NewsModel, News>();
        }
    }
}
