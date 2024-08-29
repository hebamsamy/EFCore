using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDayTwo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public double? Salary { get; set; }

        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        //Emp work on dept
        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Dept { get; set; }

        //emp manage Depart
        public int? SupervisedDepartmentID { get; set; }
        [ForeignKey("SupervisedDepartmentID")]
        public Department? SupervisedDept { get; set; }

        //emp work on many Projcet
        [InverseProperty("Emp")]
        public ICollection<WorksFor> WorksFors { get; set; }


    }
}
