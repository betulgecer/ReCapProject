using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası eklendi.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası güncellendi.");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası silindi.");
        }
    }
}
