using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.Task.Domains.Entities;
using TAL.Task.Domains.Models;

namespace TAL.Task.Api.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Occupation, OccupationModel>();
        }
    }
}
