using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Context context = new Context())
            {
                var result = from cc in context.Cars
                             join c in context.Colors
                             on cc.ColorId equals c.ColorId
                             from cb in context.Cars
                             join b in context.Brands
                             on cb.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = cc.DailyPrice,
                                 Description = cc.Description,
                                 Id = cc.Id,
                                 ModelYear = cc.ModelYear
                             };
                return result.ToList();
            }
        }
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }       

        public void Update(Car entity)
        {
            using (Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
