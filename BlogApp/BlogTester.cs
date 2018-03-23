using BlogApp.Models;
using BlogApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp
{
    class BlogTester
    {
        public static void Main(string[] args)
        {
            //GetAll();
            //GetSingle();
           // Add();
            //Delete();
            //Findby();
            //Edit();

            Console.Read();
        }

        private static void GetSingle()
        {

        }
        private static void GetAll()
        {

        }
        private static void Add()
        {
            var blog = new BlogRepository<Blog>();
            blog.Add(
                new Blog
                {
                    Name="Prolifik",
                    Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title = "Repository",
                            CreatedDate = new DateTime(2008,1,28),
                            Body = "Why use repository?"
                        }
                    }
                }
                );
        }
        private static void Delete()
        {

        }
        private static void Findby()
        {
            var doing = new BlogRepository<Blog>();
            var find = doing.FindBy(c => c.Name.Contains("Prolifik"));
            foreach (var v in find)
            {
                Console.WriteLine($"{v.Name}: {v.Posts}");
            }
        }
        private static void Edit()
        {
            var blog = new BlogRepository<Blog>();
            /// contact.Add(new Contact{FullName="Lola", MobileNo="09063742561", WorkPhoneNo="08097654312"});
            var blog2 = new Blog
            {
                Name="Muna",
                Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title = "A lifestyle Blog",
                            CreatedDate = new DateTime(23, 03, 2018),
                            Body = "Black Excellence of African descent"
                        }
                    }
            };

            blog.Add(blog2);
            blog2.Name = "Ebi";
            blog2.Posts = new List<Post>
                    {
                        new Post()
                        {
                            Title = "A lifestyle Blog",
                            CreatedDate = new DateTime(23, 03, 2018),
                            Body = "Black Excellence of African descent"
                        }
                    };
            blog.Edit(blog2);
        }
    }
}
