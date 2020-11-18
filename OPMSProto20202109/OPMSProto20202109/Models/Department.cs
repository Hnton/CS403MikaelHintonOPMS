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
    [Table("Departments", Schema = "User")]
    public class Department : EntityBase
    {
        [DataType(DataType.Text)]
        public string DepartmentName { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        [ForeignKey(nameof(DivisionID))]
        public Division Division { get; set; }

        public int DivisionID { get; set; }

        [InverseProperty(nameof(Employee.Department))]
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
