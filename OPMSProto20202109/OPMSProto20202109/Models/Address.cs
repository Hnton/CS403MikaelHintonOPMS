using OPMSProto20202109.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OPMSProto20202109.Models
{
    [Table("Addresses", Schema = "User")]
    public class Address : EntityBase
    {
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string ZIP { get; set; }

        [InverseProperty(nameof(Campus.Address))]
        public List<Campus> Campuses { get; set; } = new List<Campus>();
    }
}
