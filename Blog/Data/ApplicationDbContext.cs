using Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        DbSet<Category> Category { get; set; }

        DbSet<Language> Language { get; set; }

        DbSet<CategoryTranslation> CategoryTranslation { get; set; }

        DbSet<PostTranslation> PostTranslation { get; set; }

        DbSet<ApplicationUser> ApplicationUser { get; set; }

        DbSet<Post> Post { get; set; }

        DbSet<Tag> Tag { get; set; }

        DbSet<PostTag> PostTag { get; set; }

        DbSet<Status> Status { get; set; }
    }
}
