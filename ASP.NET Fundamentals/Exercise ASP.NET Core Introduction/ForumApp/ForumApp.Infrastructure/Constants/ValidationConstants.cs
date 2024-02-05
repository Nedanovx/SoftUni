using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infrastructure.Constants
{
	/// <summary>
	/// Constants values for model validation
	/// </summary>
	public static class ValidationConstants
	{
		/// <summary>
		/// Maximal Post Title length
		/// </summary>
		public const int TitleMaxLength = 50;

		/// <summary>
		/// Minimal Post Title length
		/// </summary>
		public const int TitleMinLength = 10;

		/// <summary>
		/// Maximal Post Content length
		/// </summary>
		public const int ContentMaxLength = 1500;

		/// <summary>
		/// Minimal Post Content length
		/// </summary>
		public const int ContentMinLength = 30;

		/// <summary>
		/// Required error text
		/// </summary>
		public const string RequiredErrorMessage = "The {0} field is required";

		public const string StringLengthErrorMessage = "The {0} field must be between {2} and {1} characters long !";
	}
}
