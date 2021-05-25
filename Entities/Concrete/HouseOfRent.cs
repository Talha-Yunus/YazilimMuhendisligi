using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HouseOfRent:IEntity
    {
        public int RentHouseId { get; set; }
        public int HouseId { get; set; }
        public decimal Price { get; set; }
        public decimal Deposit { get; set; }
    }
}
