using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Period { get; set; }
        public string PetName { get; set; }
        public string OwnerName { get; set; }
        public string Kontak { get; set; }
    }
}
