using System;
using Homework5.Abstract;

namespace Homework5.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int BirthYear { get; set; }

        public Player()
        {

        }

        public Player(int id, string firstName, string lastName, string nationalityId, int birthYear)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationalityId = nationalityId;
            BirthYear = birthYear;
        }
    }
}
