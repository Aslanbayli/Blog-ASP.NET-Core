using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostTag
    {
        public uint? Id { get; set; }

        public uint PostId { get; set; }

        public uint TagId { get; set; }

        // Relationships
        public Post Post { get; set; }

        public Tag Tag { get; set; }
    }
}
