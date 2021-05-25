using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class House :IEntity
    {
        public int HouseId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int RoomsNumber { get; set; }
        public int FloorsNumber { get; set; }
        public int HouseArea { get; set; }
        public DateTime DateOfProduction { get; set; }
        public string HouseType { get; set; }
        public string HouseSituation { get; set; }

    }
}
