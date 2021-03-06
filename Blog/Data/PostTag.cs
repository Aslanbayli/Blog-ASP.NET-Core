using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostTag
    {
        public int? Id { get; set; }

        public int PostId { get; set; }

        public int TagId { get; set; }

        // Relationships
        public Post Post { get; set; }

        public Tag Tag { get; set; }
    }
}
