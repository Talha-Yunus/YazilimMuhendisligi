using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HostDetailDto :IDto
    {
        public int HostId { get; set; }
        public string HostName { get; set; }
        public string HostSurname { get; set; }
        public string EMail { get; set; }
        public int TelNumber { get; set; }
        public string HouseType { get; set; }
        public string HouseSituation { get; set; }
        public int RoomsNumber { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
    }
}
