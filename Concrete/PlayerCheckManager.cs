using System;
using Homework5.Abstract;
using Homework5.Entities;

namespace Homework5.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return (player.FirstName == "Burak" && player.LastName == "Kosova" && player.NationalityId == "982352375" && player.BirthYear == 1999);
        }
    }
}
