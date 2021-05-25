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
    public class HostManager :IHostService
    {
        IHostDal _hostDal;


        public HostManager(IHostDal hostDal)
        {
            _hostDal = hostDal;
        }


        public IResult Add(Host host)
        {

            _hostDal.Add(host);

            return new SuccessResult();

        }


        public IDataResult<List<Host>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Host>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Host>>(_hostDal.GetAll());
        }

        public IDataResult<Host> GetById(int hostId)
        {
            return new SuccessDataResult<Host>(_hostDal.Get(p => p.HostId == hostId));
        }

        public IDataResult<List<HostDetailDto>> GetHostDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<HostDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<HostDetailDto>>(_hostDal.GetHostDetails());
        }

    }
}
