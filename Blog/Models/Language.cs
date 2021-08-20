using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string LanguageCode { get; set; }

        public string Name { get; set; }

        // Relationships
        public List<CategoryTranslation> CategoryTranslations { get; set; }

        public List<PostTranslation> PostTranslations { get; set; }
    }
}
