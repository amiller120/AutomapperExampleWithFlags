using AutoMapper;

namespace Persistence.Mappers
{
    public class PersistenceProfile : Profile
    {
        public PersistenceProfile()
        {
            // Inbound
            CreateMap<Domain.Models.Person, Models.Person>().ConvertUsing<Inbound.PersonConverter>();

            // Outbound
            CreateMap<Models.Person, Domain.Models.Person>().ConvertUsing<Outbound.PersonConverter>();
        }
    }
}
