using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDayTwo
{
    public class ProjectContext: DbContext
    {
        public ProjectContext(): base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //for database
            optionsBuilder.UseSqlServer("Data source = DESKTOP-0KJMNFC; Initial catalog = Project2; Integrated security= true; trustservercertificate = true");
            //enable lazy loading
            //other options
            optionsBuilder.LogTo(log=>Debug.WriteLine(log));

            base.OnConfiguring(optionsBuilder);
        }
        

        //tables
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<WorksFor> WorksFors { get; set; }  

    }
}
