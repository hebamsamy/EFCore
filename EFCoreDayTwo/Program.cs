namespace EFCoreDayTwo
{
    public class Program
    {
        public static void Main(string[] args) { 
            ProjectContext context = new ProjectContext();


            context.Department.Add(
                new Department
                {
                    Name = "SD",
                    Location="Aswan",
                    
                });


            context.SaveChanges();


        }
    }
}