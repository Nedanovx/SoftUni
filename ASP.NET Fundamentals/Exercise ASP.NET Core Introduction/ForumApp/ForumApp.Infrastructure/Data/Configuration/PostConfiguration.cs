﻿using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data.Configuration
{
	public class PostConfiguration : IEntityTypeConfiguration<Post>
	{
		private Post[] initialPosts = new Post[]
		{
			new Post()
			{
				Id = 1,
				Title = "My first post",
				Content = "My first post will be about performing CRUD operations in MVC. It's so much fun!"
			},
			new Post()
			{
				Id = 2,
				Title = "My second post",
				Content = "This is my second post. CRUD operations in MVC are getting more and more interesting!"
			},
			new Post()
			{
				Id = 3,
				Title = "My third post",
				Content = "Hello there! I'm getting better and better with the CRUD operations in MVC. Staytuned."
			}
		};
		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.HasData(initialPosts);
		}
	}
}
