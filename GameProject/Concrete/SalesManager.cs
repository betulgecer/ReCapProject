using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSale(User user, Game game, Campaign campaign)
        {
            double price;
            if (campaign.Discount != 0)
            {
                price = game.GamePrice - (game.GamePrice * campaign.Discount / 100);
                Console.WriteLine("İndirim Tutarı:" + price);
            }
            else
            {
                price = game.GamePrice;
            }
            Console.WriteLine("'{0}' oyunu '{1}' Kullanıcısına '{2}' kampanyası ile {3} TL karşılığında  satıldı",
                game.GameName, user.FirstName, campaign.CampaignName, price);
            Console.WriteLine("Satış başarıyla tamamlandı!");
        }
        public void Update(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış güncellendi!");
        }
        public void Delete(User user, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış silindi!");
        }
    
    }
}
