using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=100,Description="tosbag",ModelYear=1970},
            new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=120,Description="fadsf",ModelYear=1999},
            new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=150,Description="gfdgf",ModelYear=2010},
            new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=150,Description="ewrrwe",ModelYear=2009},
            new Car{Id=5,BrandId=3,ColorId=3,DailyPrice=300,Description="vınnnn",ModelYear=1968},

            };

        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars
        }

        public List<Car> GetByBrandId(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public List<Car> GetByColorId(int id)
        {
            return _cars.Where(c => c.ColorId == id).ToList();
        }

        public List<Car> GetById(int id) 
        {
            return _cars.Where(c => c.Id == id).ToList(); 
        }
            

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
            carToUpdate.ModelYear = entity.ModelYear;
        }
    }
}
