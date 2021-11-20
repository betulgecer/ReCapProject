using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game : IEntities
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
