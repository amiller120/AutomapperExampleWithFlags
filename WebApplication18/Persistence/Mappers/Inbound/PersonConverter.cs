using AutoMapper;
using Domain.Models;

namespace WebApplication18.Persistence.Mappers.Inbound
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
                person.Tired = DetermineMood((int)MoodStatus.Tired, person.MoodStatus);
                person.Sad = DetermineMood((int)MoodStatus.Sad, person.MoodStatus);
                person.Bored = DetermineMood((int)MoodStatus.Bored, person.MoodStatus);
                person.Happy = DetermineMood((int)MoodStatus.Happy, person.MoodStatus);
                person.Joyous = DetermineMood((int)MoodStatus.Joyous, person.MoodStatus);
            }

            return person;
        }

        private bool DetermineMood(int flagToCheck, int moodStatus)
        {
            return (moodStatus & flagToCheck) > 0;
        }
    }
}
