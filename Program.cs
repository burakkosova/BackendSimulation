using System;
using Homework5.Abstract;
using Homework5.Concrete;
using Homework5.Entities;

namespace Homework5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player player = new Player(1, "Burak", "Kosova", "982352375", 1999);


            Player player1 = new Player(2, "Kendall", "Jenner", "345344356", 1995);

            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());

            try
            {
                playerManager.Save(player);
                playerManager.Save(player1);
                playerManager.Update(player);
                playerManager.Delete(player);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Game game = new Game
            {
                Id = 1,
                Name = "Grand Theft Auto",
                Price = 150
            };

            Game game1 = new Game
            {
                Id = 2,
                Name = "Far Cry 5",
                Price = 225
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "Black Friday",
                DiscountPercentage = 20,
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(player, game);
            salesManager.SellWithCampaign(player1, game1, campaign);

        }
    }
}
