using AutoMapper;

namespace Persistence.Mappers.Outbound
{
    public class PersonConverter : ITypeConverter<Models.Person, Domain.Models.Person>
    {
        public Domain.Models.Person Convert(Models.Person source, Domain.Models.Person destination, ResolutionContext context)
        {
            Domain.Models.Person person = null;

            if (source != null)
            {
                person = new Domain.Models.Person
                {
                    FirstName = source.FirstName,
                    LastName = source.LastName,
                    Mood = (Domain.Models.MoodStatus)source.MoodStatus
                };
            }

            return person;
        }
    }
}
