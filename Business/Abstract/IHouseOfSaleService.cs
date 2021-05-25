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
    public interface IHouseOfSaleService
    {
        IDataResult<List<HouseOfSale>> GetAll();
        IDataResult<List<HouseOfSale>> GetByPrice(decimal min, decimal max);
        IDataResult<List<SaleDetailDto>> GetSaleDetails();
        IDataResult<HouseOfSale> GetById(int houseOfSaleId);
        IResult Add(HouseOfSale houseOfSale);
        IResult Update(HouseOfSale houseOfSale);
        IDataResult<List<House>> GetAllByHouseType(string houseType);
    }
}
