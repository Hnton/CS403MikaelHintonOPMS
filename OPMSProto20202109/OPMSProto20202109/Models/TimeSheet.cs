using OPMSProto20202109.Areas.Data;
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
    [Table("TimeSheet", Schema = "User")]
    public class TimeSheet : EntityBase
    {
        [Required]
        public string UserID { get; set; }

        [Required]
        [DefaultValue(ApprovalTypes.Waiting)]
        public ApprovalTypes Approved { get; set; }

        public string ReasonDenied { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public bool ExemptFromOvertime { get; set; }

        [ForeignKey(nameof(UserID))]
        public Employee User { get; set; }


        [InverseProperty(nameof(ClockInOut.TimeSheet))]
        public virtual List<ClockInOut> ClockIns { get; set; }
    }

}
