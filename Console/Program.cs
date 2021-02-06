using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService(new InMemoryCarDal());

            foreach (var item in carService.GetByColorId(3))
            {
                Console.WriteLine(item.Description);
            }
            
        }
    }
}
