

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDayTwo
{
    [Table("Department", Schema ="HR")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [Required]
        [Column("Name",TypeName ="varchar(50)")]
        //[StringLength(50)]
        public string Name { get; set; }


        public string Location { get; set; }

        [InverseProperty("Dept")]
        public  ICollection<Employee> Employees { get; set; }

        [InverseProperty("SupervisedDept")]
        public Employee Supervisor { get; set; }

        [InverseProperty("Department")]
        public ICollection<Project> Projects { get; set; }
    }
}
