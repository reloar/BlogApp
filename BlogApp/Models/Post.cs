using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
   public class Post:BaseModel
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Body { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
