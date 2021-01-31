using System;
using Homework5.Abstract;
using Homework5.Entities;

namespace Homework5.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("{0} {1} isimli oyuncu kaydedildi.", player.FirstName, player.LastName);
            }
            else
            {
                throw new Exception("Not a valid user");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("{0} {1} isimli oyuncunun kaydı silindi.", player.FirstName, player.LastName);
        }


        public void Update(Player player)
        {
            Console.WriteLine("{0} {1} isimli oyuncu güncellendi.", player.FirstName, player.LastName);
        }
    }
}
