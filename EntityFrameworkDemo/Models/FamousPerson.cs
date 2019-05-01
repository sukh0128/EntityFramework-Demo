namespace EntityFrameworkDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FamousPerson
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FamousLevel { get; set; }

        public DateTime Birthdate { get; set; }

        public DateTime? PassedDate { get; set; }
    }

    
}