using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarService : ICarService

    {
        ICarDal _carDal;

        

        public CarService(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>1)
            {
                if (car.DailyPrice>0)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Dialy price must be greater than 0");
                }
            }
            else
            {
                Console.WriteLine("Not allowed to enter less than 2 character");      
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.Id==id);
        }
    }
}
