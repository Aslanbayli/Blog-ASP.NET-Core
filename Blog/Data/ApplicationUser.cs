using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<PostTranslation> PostTranslations { get; set; }

        public ApplicationUser()
        {

        }
    }

}



