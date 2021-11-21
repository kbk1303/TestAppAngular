using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppAngular.DataTransferObjects;
using TestAppAngular.Models;

namespace TestAppAngular.Profiles
{
    public class InformationsProfile : Profile
    {
        public InformationsProfile()
        {
            // source -> dest
            CreateMap<Information, InformationReadDto>();
            CreateMap<InformationCreateDto, Information>();
            CreateMap<InformationUpdateDto, Information>();
        }
    }
}
