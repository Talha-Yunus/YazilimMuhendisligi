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
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;


        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }


        public IResult Add(House house)
        {

            _houseDal.Add(house);

            return new SuccessResult();

        }


        public IDataResult<List<House>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<House>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<House>>(_houseDal.GetAll());
        }

        public IDataResult<House> GetById(int houseId)
        {
            return new SuccessDataResult<House>(_houseDal.Get(p => p.HouseId == houseId));
        }

        public IDataResult<List<HouseDetailDto>> GetHouseDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<HouseDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<HouseDetailDto>>(_houseDal.GetHouseDetails());
        }


        public IResult Update(House house)
        {
            throw new NotImplementedException();
        }


        public IDataResult<List<House>> GetAllByHouseType(string houseType)
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(p => p.HouseType == houseType));
        }
    }
}
