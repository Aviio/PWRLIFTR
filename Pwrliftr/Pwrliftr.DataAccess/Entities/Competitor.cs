using System;

namespace Pwrliftr.DataAccess.Entities
{
    public class Competitor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double KiogramWeight { get; set; }


    }
}