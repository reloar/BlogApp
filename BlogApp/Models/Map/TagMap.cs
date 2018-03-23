using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models.Map
{
    public class TagMap: EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            this.Property(p => p.Name).HasMaxLength(50);
        }
    }
}
