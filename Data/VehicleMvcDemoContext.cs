using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VehicleMvcDemo.Models
{
    public class VehicleMvcDemoContext : DbContext
    {
        public VehicleMvcDemoContext (DbContextOptions<VehicleMvcDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
