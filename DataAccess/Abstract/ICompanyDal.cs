using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        List<CompanyDetailDto> GetCompanyDetails();
    }
}
