using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ABlogging.Models;
using BloggingWeb.Models;

namespace ABlogging.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ABlogging.Models.Post> Post { get; set; }
        public DbSet<ABlogging.Models.Comment> Comment { get; set; }
        public DbSet<BloggingWeb.Models.Person> People { get; set; }
    }
}
