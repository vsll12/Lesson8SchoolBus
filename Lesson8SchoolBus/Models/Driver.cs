using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8SchoolBus.Models
{
    internal class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public int RideId { get; set; }
        public Ride Ride { get; set; }
        public string HomeAdress { get; set; }
        public string LicenseNumber { get; set; }
    }
}
