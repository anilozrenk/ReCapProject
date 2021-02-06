using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICarService
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        List<Car> GetByBrandId(int id);
        List<Car> GetByColorId(int id);

    }
}
