using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Tag
    {
        public uint Id { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }
    }
}
