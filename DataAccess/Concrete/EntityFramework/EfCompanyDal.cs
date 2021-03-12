using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, Context>, ICompanyDal
    {
        public List<CompanyDetailDto> GetCompanyDetails()
        {
            using (Context context = new Context())
            {
                var result = from c in context.Companies
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CompanyDetailDto
                             {
                                 Id=c.Id,
                                 CompanyName=c.CompanyName,
                                 Email=u.Email,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName
                             };
                return result.ToList();
            }


        }
    }
}
