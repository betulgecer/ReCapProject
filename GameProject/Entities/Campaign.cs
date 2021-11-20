using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign : IEntities
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Discount { get; set; } //İndirim
        public DateTime StartingDate { get; set; } //bAşlangıç Tarihi
        public DateTime DueDate { get; set; } //Bitiş Tarihi
    }
}
