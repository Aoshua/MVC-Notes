using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMvcDemo.Models
{
    public class VehicleMakeViewModel
    {
        public List<Vehicle> Vehicles { get; set; }
        public SelectList Makes { get; set; }
        public string VehicleMake { get; set; }
        public string SearchString { get; set; }
    }
}
