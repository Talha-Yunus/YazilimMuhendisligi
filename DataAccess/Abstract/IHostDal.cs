using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHostDal : IEntityRepository<Host>
    {
        List<HostDetailDto> GetHostDetails();
    }
}
