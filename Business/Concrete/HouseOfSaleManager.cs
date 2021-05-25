using Business.Abstract;
using Business.Constants;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseOfSaleManager : IHouseOfSaleService
    {
        IHouseOfSaleDal _houseOfSale;
        IHouseDal _houseDal;

        public HouseOfSaleManager(IHouseOfSaleDal houseOfSale)
        {
            _houseOfSale = houseOfSale;
        }


        public IResult Add(HouseOfSale houseOfSale)
        {

            _houseOfSale.Add(houseOfSale);

            return new SuccessResult();

        }

        public IDataResult<List<HouseOfSale>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<HouseOfSale>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<HouseOfSale>>(_houseOfSale.GetAll());
        }

        public IDataResult<List<House>> GetAllByHouseType(string houseType)
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(p => p.HouseType == houseType));
        }

        public IDataResult<HouseOfSale> GetById(int houseOfSaleId)
        {
            return new SuccessDataResult<HouseOfSale>(_houseOfSale.Get(p => p.HouseId == houseOfSaleId));
        }

        public IDataResult<List<HouseOfSale>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<HouseOfSale>>(_houseOfSale.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<List<SaleDetailDto>> GetSaleDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<SaleDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<SaleDetailDto>>(_houseOfSale.GetSaleDetails());
        }

        public IResult Update(HouseOfSale houseOfSale)
        {
            throw new NotImplementedException();
        }
    }
}
