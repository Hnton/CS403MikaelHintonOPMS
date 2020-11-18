using Microsoft.AspNetCore.Identity;
using OPMSProto20202109.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OPMSProto20202109.Areas.Data
{
    [Table("Employees", Schema = "User")]
    public class Employee : IdentityUser
    {
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        public Department Department { get; set; }

        public int? DepartmentID { get; set; }


        [InverseProperty(nameof(Division.Supervisor))]
        public List<Division> Divisions { get; set; } = new List<Division>();

        [Required]
        [DefaultValue(false)]
        public bool ExemptFromOvertime { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double HourlyWage { get; set; }

        [InverseProperty(nameof(TimeSheet.User))]
        public List<TimeSheet> TimeSheets { get; set; }

    }
}