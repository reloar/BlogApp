using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models.Map
{
   public class BlogMap: EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            
           // this.HasRequired(a => a.Posts);
            this.Property(a => a.Name).HasMaxLength(50);

            
        }

    }
}
