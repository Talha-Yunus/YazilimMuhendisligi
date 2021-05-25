using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Host :IEntity
    {
        public int HostId { get; set; }
        public int HouseId { get; set; }
        public string HostName { get; set; }
        public string HostSurname { get; set; }
        public int TelNumber { get; set; }
        public int Identification { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
    }
}
