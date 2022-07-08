using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Model
{
    public class BlogPost
    {
        public int id { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public DateTime timestamp { get; set; }
        public int categoryId { get; set; }
    }
}
