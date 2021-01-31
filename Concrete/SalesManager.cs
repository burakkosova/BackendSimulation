using System;
using Homework5.Entities;
using Homework5.Abstract;

namespace Homework5.Concrete
{
    public class SalesManager : ISaleService
    {
        public void Sell(Player player, Game game)
        {
            Console.WriteLine("{0} oyunu {1} {2} isimli oyuncuya {3}₺ tutarına satıldı",
                game.Name,
                player.FirstName,
                player.LastName,
                game.Price
            );
        }

        public void SellWithCampaign(Player player, Game game, Campaign campaign)
        {
            double newPrice = game.Price - (game.Price * campaign.DiscountPercentage / 100);

            Console.WriteLine("{0} oyunu {1} {2} isimli oyuncuya %{3} indirimle {4}₺ tutarına satıldı",
                game.Name,
                player.FirstName,
                player.LastName,
                campaign.DiscountPercentage,
                newPrice
             );
        }
    }
}
