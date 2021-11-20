using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void CampaignSale(User user, Game game, Campaign campaign);
        void Update(User user, Game game, Campaign campaign);
        void Delete(User user, Game game, Campaign campaign);
    }
}
