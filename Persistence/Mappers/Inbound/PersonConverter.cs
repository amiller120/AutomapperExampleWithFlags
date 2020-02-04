using AutoMapper;

namespace Persistence.Mappers.Inbound
{
    public class PersonConverter : ITypeConverter<Domain.Models.Person, Models.Person>
    {
        public Models.Person Convert(Domain.Models.Person source, Models.Person destination, ResolutionContext context)
        {
            Models.Person person = null;

            if (source != null)
            {
                person = new Models.Person
                {
                    FirstName = source.FirstName,
                    LastName = source.LastName,
                    MoodStatus = (int)source.Mood,
                    
                };
                person.Tired = DetermineMood(1, person.MoodStatus);
                person.Sad = DetermineMood(2, person.MoodStatus);
                person.Bored = DetermineMood(4, person.MoodStatus);
                person.Happy = DetermineMood(8, person.MoodStatus);
                person.Joyous = DetermineMood(16, person.MoodStatus);
            }

            return person;
        }

        private bool DetermineMood(int flagToCheck, int moodStatus)
        {
            return (moodStatus & flagToCheck) > 0;
        }
    }
}
