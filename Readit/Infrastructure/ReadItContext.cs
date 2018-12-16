using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Readit.Infrastructure
{
    public class ReadItContext : DbContext
    {
        public ReadItContext(DbContextOptions<ReadItContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string PostedBy { get; set; }
    }
}
