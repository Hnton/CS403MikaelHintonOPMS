using OPMSProto20202109.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OPMSProto20202109.Models.ViewModels
{
    public class CampusAndAddressViewModels : EntityBase
    {
        [Required]
        [Display(Name = "Campus Name")]
        public string CampusName { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [MaxLength(10)]
        [Required]
        public string ZIP { get; set; }
    }
}
