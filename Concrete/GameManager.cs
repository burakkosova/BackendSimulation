using System;
using Homework5.Abstract;
using Homework5.Entities;

namespace Homework5.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu sisteme eklendi.",game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} oyunu sistemden silindi.", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} oyunu güncellendi.", game.Name);
        }
    }
}
