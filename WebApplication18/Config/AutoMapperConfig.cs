using AutoMapper;
using Persistence.Mappers;

namespace WebApplication18.Config
{
    public class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PersistenceProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            return mapper;
        }
    }
}
