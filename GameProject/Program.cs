using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı
            User user1 = new User() { Id = 1, FirstName = "Betül", LastName = "Geçer", BirthYear = 1998, NationalityId = "42517863259" };
            User user2 = new User() { Id = 2, FirstName = "Selim", LastName = "Bakır", BirthYear = 1998, NationalityId = "75694236158" };

            UserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(user1);

            //Oyun
            Game game1 = new Game() { Id = 1, GameName = "Mobile Legends", GamePrice = 250 };
            Game game2 = new Game() { Id = 2, GameName = "Legends Of Legends", GamePrice = 150 };
            Game game3 = new Game() { Id = 3, GameName = "Minecraft", GamePrice = 100 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Delete(game2);
            gameManager.Add(game3);

            //Kampanya
            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "Yaz Kampanyası", Discount = 50 , StartingDate = new DateTime(2021,06,1), DueDate = new DateTime(2018, 08, 31) };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "Kış Kampanyası", Discount = 50 , StartingDate = new DateTime(2021, 10, 1), DueDate = new DateTime(2021, 12, 31) };
            Campaign campaign3 = new Campaign() { Id = 3, CampaignName = "Black Friday Kampanyası", Discount = 90 , StartingDate = new DateTime(2021, 09, 1), DueDate = new DateTime(2021, 09, 4) };
            Campaign campaign4 = new Campaign() { Id = 4, CampaignName = "İlk Alışverişe %25 İndirim", Discount = 25 , StartingDate = new DateTime(2021, 03, 1), DueDate = new DateTime(2021, 04, 1) };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            campaignManager.Add(campaign4);

            //Satış
            SalesManager salesManager = new SalesManager();
            salesManager.CampaignSale(user1, game1, campaign3);
            salesManager.Update(user2, game3, campaign2);

            Console.ReadLine();

        }
    }
}
