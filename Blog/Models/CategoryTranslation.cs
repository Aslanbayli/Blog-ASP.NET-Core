using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class CategoryTranslation
    {
        public uint? Id { get; set; }

        public uint CategoryId { get; set; }

        public uint LanguageId { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }

        public string Body { get; set; }

        // Relationships
        public Category Category { get; set; }

        public Language Language { get; set; }
    }
}
