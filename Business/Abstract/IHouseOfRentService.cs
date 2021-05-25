using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHouseOfRentService
    {
        IDataResult<List<HouseOfRent>> GetAll();
        IDataResult<List<HouseOfRent>> GetByPrice(decimal min, decimal max);
        IDataResult<List<RentDetailDto>> GetRentDetails();
        IDataResult<HouseOfRent> GetById(int houseOfRentId);
        IResult Add(HouseOfRent houseOfRent);
        IResult Update(HouseOfRent houseOfRent);
        IDataResult<List<House>> GetAllByHouseType(string houseType);
    }
}
