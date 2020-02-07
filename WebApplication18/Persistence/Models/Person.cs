using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Persistence.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int MoodStatus { get; set; }

        public bool None => MoodStatus == 0;

        public bool Tired { get; set; }

        public bool Sad { get; set; }

        public bool Bored { get; set; }

        public bool Happy { get; set; }

        public bool Joyous { get; set; }
    }
}
