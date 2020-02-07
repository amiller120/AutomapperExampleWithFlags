using AutoMapper;
using WebApplication18.Persistence.Mappers;

namespace WebApplication18.Config
{
    public class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PersistenceAutoMapperProfiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            return mapper;
        }
    }
}
