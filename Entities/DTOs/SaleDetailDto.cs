using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SaleDetailDto :IDto
    {
        public int SaleHouseId { get; set; }
        public decimal Price { get; set; }
        public int RoomsNumber { get; set; }
        public int FloorsNumber { get; set; }
        public int HouseArea { get; set; }
        public DateTime DateOfProduction { get; set; }
        public string HouseType { get; set; }
        public string HouseSituation { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
    }
}
