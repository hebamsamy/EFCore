using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDayTwo
{
    public class WorksFor
    {
        public int ID { get; set; }

        public int Hours { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Emp { get; set; }
        public  int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public  Project Proj { get; set; }
    }
}
