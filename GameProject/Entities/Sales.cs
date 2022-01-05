using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Sales : IEntities
    {
        public DateTime SaleDate { get; set; }
        public double Price { get; set; }
    }
}
