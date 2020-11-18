using OPMSProto20202109.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OPMSProto20202109.Models
{
    [Table("Campuses", Schema = "User")]
    public class Campus : EntityBase
    {
        [Required]
        public string CampusName { get; set; }

        [ForeignKey(nameof(AddressID))]
        public Address Address { get; set; }

        public int AddressID { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

    }
}