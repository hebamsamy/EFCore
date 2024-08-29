using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EFCoreDayOne
{

    public class Program
    {
        public static void Main()
        {

            ////Add

            //context.Authors.Add(
            //    new Author
            //    {
            //        WebSite = "https://test.com",
            //        Name = "TEST",
            //        PhoneNumber = "0111111111"
            //    }
            //    );

            //UPDATE
            //try
            //{
            //    var quary = context.Books.Where(a => a.ID == 7).FirstOrDefault();

            //    if (quary != null)
            //    {
            //        quary.Price -= 100;

            //    }
            //    context.SaveChanges();
            //}
            //catch (Exception ex) { 
            //}


            //DELETE
            //var quary = context.Authors.Where(a => a.ID == 11).FirstOrDefault();

            //if (quary != null)
            //{
            //    context.Authors.Remove(quary);

            //}
            //context.SaveChanges();


            //Read

            ProjectContext context = new ProjectContext();

            //Deferid
            //var quary = context.Books
            //    .Where(b => b.Title.Contains("Entity"))
            //    .Include(b => b.Publisher)
            //    .Include(b => b.Authers);

            var quary = context.Books.Where(b => b.Title.Contains("Entity"));

          
            foreach (var item in quary)
            {
                //EXplicit
                //context.Books.Entry(item).Collection(b=>b.Authers);
                Console.WriteLine($"{item.Title} {item.Price} {item.Publisher.Name}");
                foreach (var auther in item.Authers)
                {
                    Console.WriteLine($"{ auther.Author.Name }");
                }
            }


        }
    }
}