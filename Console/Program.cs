using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carService = new CarService(new EfCarDal());
            var result = carService.GetByColorId(3);
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Description);
            }
            
                
            
            
        }
    }
}
