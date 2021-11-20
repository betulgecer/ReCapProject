using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı pyunn güncellendi.");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi.");
        }
    }
}
