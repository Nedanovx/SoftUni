using ForumApp.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Data.Models
{
	[Comment("Posts table")]
	public class Post
	{
		[Key]
		[Comment("Post identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(ValidationConstants.TitleMaxLength)]
		[Comment("Post title")]
		public string Title { get; set; } = string.Empty;

		[Required]
		[MaxLength(ValidationConstants.ContentMaxLength)]
		public string Content {  get; set; } = string.Empty;
	}
}
