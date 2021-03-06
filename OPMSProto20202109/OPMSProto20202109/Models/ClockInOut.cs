﻿using OPMSProto20202109.Areas.Data;
using OPMSProto20202109.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OPMSProto20202109.Models
{
    [Table("ClockInOut", Schema = "User")]
    public class ClockInOut : EntityBase
    {

        [ForeignKey(nameof(EmployeeID))]
        public Employee Supervisor { get; set; }

        public string EmployeeID { get; set; }

        [Required]
        public DateTime ClockInTime { get; set; }

        public DateTime? ClockOutTime { get; set; }

        [Required]
        public int TimeSheetID { get; set; }

        [ForeignKey(nameof(TimeSheetID))]
        public TimeSheet TimeSheet { get; set; }
    }
}
