using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetAPI.Models;

namespace VetAPI.Data
{
    public class VetAPIContext : DbContext
    {
        public VetAPIContext (DbContextOptions<VetAPIContext> options)
            : base(options)
        {
        }

        public DbSet<VetAPI.Models.Appointment> Appointment { get; set; }
    }
}
