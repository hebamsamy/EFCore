using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDayOne
{
  public class Publisher
  {
        public int ID { get; set; }
        public string Name {get; set;}
        public string WebSite {get; set;}

        public virtual ICollection<Book> Books { get; set;}

  }
    public class PublisherConfigration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            ///
        }
    }


}
