using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetAll())
            {
                System.Console.WriteLine(c.Description);
            }
        }
    }
}
