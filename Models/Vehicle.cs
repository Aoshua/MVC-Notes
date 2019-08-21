using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleMvcDemo.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string VehicleMake { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string VehicleModel { get; set; }

        [Required]
        [Display(Name = "Year")]
        public string VehicleYear { get; set; }

        [Required]
        [Display(Name = "VIN")]
        [RegularExpression(@"[a-zA-Z0-9]{9}[a-zA-Z0-9-]{2}[0-9]{6}")]
        public string VehicleVin { get; set; }

        [Display(Name = "Notes")]
        public string VehicleNote { get; set; }
    }
}
