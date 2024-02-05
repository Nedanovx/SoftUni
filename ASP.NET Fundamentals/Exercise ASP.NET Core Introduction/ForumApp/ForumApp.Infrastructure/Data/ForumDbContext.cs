using ForumApp.Infrastructure.Data.Configuration;
using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data
{
	public class ForumDbContext : DbContext
	{
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PostConfiguration());
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<Post> Posts { get; set; }
    }
}
