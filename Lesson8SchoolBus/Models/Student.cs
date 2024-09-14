using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8SchoolBus.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParentId { get; set; }
        public int ClassId { get; set; }
        public string HomeAddress { get; set; }
        public string? OtherAddress { get; set; }
        public Parent Parent { get; set; }
        public Class Class { get; set; }
        public int? RideId { get; set; }
        public Ride? Ride { get; set; }
    }
}
