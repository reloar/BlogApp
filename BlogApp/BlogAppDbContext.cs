using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogApp.Models.Map;

namespace BlogApp
{
    public class BlogAppDbContext:DbContext
    {
        public BlogAppDbContext():base("BlogAppDbContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new AuthorMap());
          
        }

    }
}
