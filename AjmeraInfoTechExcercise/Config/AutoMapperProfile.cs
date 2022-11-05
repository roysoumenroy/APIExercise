using AITExcercise.DBEntity.Models;
using AITExcercise.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjmeraInfoTechExcercise.API.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TblBook, GetBookResult>();
        }
    }
}
