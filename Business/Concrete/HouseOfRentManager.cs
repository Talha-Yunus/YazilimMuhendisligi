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
    public class HouseOfRentManager :IHouseOfRentService
    {
        IHouseOfRentDal _houseOfRentDal;
        IHouseDal _houseDal;


        public HouseOfRentManager(IHouseOfRentDal houseOfRentDal)
        {
            _houseOfRentDal = houseOfRentDal;
        }


        public IResult Add(HouseOfRent houseOfRent)
        {

            _houseOfRentDal.Add(houseOfRent);

            return new SuccessResult();

        }

        public IDataResult<List<HouseOfRent>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<HouseOfRent>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<HouseOfRent>>(_houseOfRentDal.GetAll());
        }

        public IDataResult<List<House>> GetAllByHouseType(string houseType)
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(p => p.HouseType == houseType));
        }

        public IDataResult<HouseOfRent> GetById(int houseOfRentId)
        {
            return new SuccessDataResult<HouseOfRent>(_houseOfRentDal.Get(p => p.HouseId == houseOfRentId));
        }

        public IDataResult<List<HouseOfRent>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<HouseOfRent>>(_houseOfRentDal.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<List<RentDetailDto>> GetRentDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<RentDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RentDetailDto>>(_houseOfRentDal.GetRentDetails());
        }

        public IResult Update(HouseOfRent houseOfRent)
        {
            throw new NotImplementedException();
        }
    }
}
