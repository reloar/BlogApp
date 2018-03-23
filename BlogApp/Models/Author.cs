using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
   public class Author:BaseModel
    {
        public string FullName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
