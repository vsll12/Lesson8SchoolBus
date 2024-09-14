using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8SchoolBus.Models
{
    internal class Ride
    {
        public int Id { get; set; }
        //public int DriverId { get; set; }
        //public Driver Driver { get; set; }
        public List<Student> Students { get; set; }
        public string FullName { get; set; }
        public string CarName { get; set; }
        public string CarNumber { get; set; }
        public int MaxSeats { get; set; }
        public int StudentsAttend { get; set; }

    }
}
