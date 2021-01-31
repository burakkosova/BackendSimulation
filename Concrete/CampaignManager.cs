using System;
using Homework5.Abstract;
using Homework5.Entities;

namespace Homework5.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası sisteme eklendi",campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası silindi", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası güncellendi", campaign.Name);
        }
    }
}
