using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDayOne
{
  public class Author
  {
        public int ID { get; set; }
        public string Name {get; set;}
        public string WebSite { get; set;}

        public string PhoneNumber {get; set;}
         
        public virtual ICollection<AutherBook> Books { get; set;}
        //public ICollection<Book> Books { get; set;}
  }
    public class AuthorConfigration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            
        }
    }
}