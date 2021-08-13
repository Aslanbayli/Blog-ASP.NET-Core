using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostTranslation
    {
        public uint Id { get; set; }

        public uint PostId { get; set; }

        public uint CategoryId { get; set; }

        public uint LanguageId { get; set; }

        public uint ApplicationUserId { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }

        public string Summary { get; set; }

        public string Body { get; set; }

        public DateTime? LastChanged { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        // Relationships
        public Category Category { get; set; }

        public Language Language { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Post Post { get; set; }

    }
}
