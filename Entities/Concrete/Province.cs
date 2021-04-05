using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Province :IEntity
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
    }
}
