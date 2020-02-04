using System;

namespace WebApplication18.DoesNotFitElseWhere
{
    public class NoNamePersonExtractor
    {
        public static Domain.Models.Person CreatePerson()
        {
            Array values = Enum.GetValues(typeof(Domain.Models.MoodStatus));
            Random random = new Random();
            var person = new Domain.Models.Person { FirstName = "No", LastName = "Name", Mood = ((Domain.Models.MoodStatus)values.GetValue(random.Next(values.Length)) | (Domain.Models.MoodStatus)values.GetValue(random.Next(values.Length))) };
            return person;
        }
    }
}
