namespace BlogApp.Migrations
{
    using BlogApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogApp.BlogAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogApp.BlogAppDbContext context)
        {
            base.Seed(context);

            InsertAuthor();
          InsertBlog();
            InsertPost();
           
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }

        private  void InsertAuthor() 
        {
            var author1 = new Author()
            {
                FullName = "Muna Chimso",
                Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title ="African Beauty",
                            CreatedDate =new DateTime(2006,05,28),
                            Body ="One Nigeria, One Africa"
                        }
                    },
            };
               var author2 =  new Author()
                {
                    FullName = "Prolifik",
                    Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title ="Seed To Fruition",
                            CreatedDate =new DateTime(2005,08,30),
                            Body ="Having a seed is the start, growth is needed"
                        }
                    }
                };
       
            using (var context = new BlogAppDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Set<Author>().AddRange(new List<Author> { author1, author2 });
                context.SaveChanges();
            }
        }
        private void InsertBlog()
        {
           var blog1= new Blog()
            {
                Name = "TBF",
                Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title = "Moment With Mo",
                            CreatedDate = new DateTime(2018,01,23),
                            Body = "Every Second count"
                        }
                    }
            }; 
            var blog2 = new Blog()
                {
                    Name = "Muna",
                    Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title ="SuperMan",
                            CreatedDate =new DateTime(2007,06,29),
                            Body ="Review on batman superman"
                        }
                    }
                };

            using (var context = new BlogAppDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Set<Blog>().AddRange(new List<Blog> { blog1,blog2 });
                context.SaveChanges();
            }
        }
        private void InsertPost()
        {
            var Post1=new Post()
            {
                Title = "C#",
                Body = "Entity Framework",
                CreatedDate = new DateTime(2018,09,25)
            };
             var Post2 =  new Post()
             {
                 Title = "Interface",
                 Body = "Working with repository pattern",
                 CreatedDate = new DateTime(1990,07,28)
             };
            var Post3 = new Post()
            {
                Title = "Gelegate",
                Body = "Generic Delegate",
                CreatedDate = new DateTime(1989,06,26)
            };
            var Post4 = new Post()
            {
                Title = "Extension",
                Body = "Extension Method",
                CreatedDate = new DateTime(2001,08,27)
            };
            var Post5 = new Post()
            {
                Title = "Entityframework",
                Body = "Migration",
                CreatedDate = new DateTime(2002,05,30)
            };
            using (var context = new BlogAppDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Set<Post>().AddRange(new List<Post> { Post1,Post2,Post3,Post4,Post5});
                context.SaveChanges();
            }
        }
    }
}
