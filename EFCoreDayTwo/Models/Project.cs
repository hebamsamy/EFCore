using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDayTwo
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //project on Depart
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public  Department Department { get; set; }

        [InverseProperty("Proj")]
        public  ICollection<WorksFor> WorksFors { get; set; }


    }
}
