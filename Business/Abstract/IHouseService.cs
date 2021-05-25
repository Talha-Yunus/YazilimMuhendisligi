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
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll();
        IDataResult<List<HouseDetailDto>> GetHouseDetails();
        IDataResult<House> GetById(int houseId);
        IResult Add(House house);
        IResult Update(House house);
        IDataResult<List<House>> GetAllByHouseType(string houseType);
    }
}
