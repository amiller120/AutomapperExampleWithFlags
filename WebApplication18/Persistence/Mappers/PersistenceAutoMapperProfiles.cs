using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Persistence.Mappers
{
    public class PersistenceAutoMapperProfiles : Profile
    {
        public PersistenceAutoMapperProfiles()
        {
            // Inbound
            CreateMap<Domain.Models.Person, Models.Person>().ConvertUsing<Inbound.PersonConverter>();

            // Outbound
            CreateMap<Models.Person, Domain.Models.Person>().ConvertUsing<Outbound.PersonConverter>();
        }
    }
}
