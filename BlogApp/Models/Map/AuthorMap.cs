using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models.Map
{
   public class AuthorMap:EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            this.Property(a => a.FullName).HasMaxLength(50);
            
        }
    }
}
