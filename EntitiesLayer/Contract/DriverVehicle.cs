using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Contract
{
    public class DriverVehicle
    {
        [Key]
        public int DriveId { get; set; }
        public int DriversId { get; set; }
        public  Drivers Drives { get; set; }
        public int VehicleId { get; set; }
        public Vehicles Vehicles { get; set; }
        public DateTime IdentificationDate { get; set; }
        public DateTime TerminationDate { get; set; }
    }
}
