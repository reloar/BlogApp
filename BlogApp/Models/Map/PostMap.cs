using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models.Map
{
    public class PostMap: EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            this.Property(p => p.Body).HasMaxLength(1000);
            this.Property(p => p.Title).HasMaxLength(50);
        }
    
    }
}
