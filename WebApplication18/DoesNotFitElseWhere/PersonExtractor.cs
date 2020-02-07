using System;
using System.Collections.Generic;

namespace WebApplication18.DoesNotFitElseWhere
{
    public class PersonExtractor
    {
        public static Domain.Models.Person CreatePerson()
        {
            Array values = Enum.GetValues(typeof(Domain.Models.MoodStatus));
            List<string> names = new List<string>
            {
                "George",
                "Madden",
                "Hulk",
                "Hogan",
                "Maxx",
                "Powers"
            };
            Random random = new Random();
            var person = new Domain.Models.Person { FirstName = names[random.Next(names.Count)], LastName = names[random.Next(names.Count)], Mood = ((Domain.Models.MoodStatus)values.GetValue(random.Next(values.Length)) | (Domain.Models.MoodStatus)values.GetValue(random.Next(values.Length))) };
            return person;
        }
    }
}
