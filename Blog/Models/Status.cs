using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Status
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // Relationships
        public List<Post> Posts { get; set; }

        public List<Category> Categories { get; set; }
    }
}
