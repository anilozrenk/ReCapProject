using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, Context>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (Context context = new Context())
            {
                var result = from rentals in context.Rentals
                             join cars in context.Cars
                             on rentals.CarId equals cars.Id
                             join users in context.Users
                             on rentals.CustomerId equals users.Id
                             join brands in context.Brands
                             on cars.BrandId equals brands.BrandId
                             select new RentalDetailDto
                             {
                                 Id=rentals.Id,
                                 CarId=cars.Id,
                                 UserId=users.Id,
                                 RentDate=rentals.RentDate,
                                 ReturnDate=rentals.ReturnDate,
                                 CarBrand=brands.BrandName,
                                 UserName=users.FirstName + " " + users.LastName
                             };
                return result.ToList();
            }
            

        }
    }
}
