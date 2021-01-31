using System;
using Homework5.Entities;

namespace Homework5.Abstract
{
    public interface ISaleService
    {
        void Sell(Player player, Game game);
        void SellWithCampaign(Player player, Game game, Campaign campaign);
    }
}
