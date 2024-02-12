using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data.Models;

namespace TaskBoardApp.Data.Configuration
{
    public static class ConfigurationHelper
    {
        public static IdentityUser testUser = GetUser();

        public static Board openBoard = new Board()
        {
            Id = 1,
            Name = "Open"
        };
        public static Board inProgressBoard = new Board()
        {
            Id = 2,
            Name = "In Progress"
        };
        public static Board doneBoard = new Board()
        {
            Id = 3,
            Name = "Done"
        };

        private static IdentityUser GetUser()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                UserName = "test@softuni.bg",
                NormalizedUserName = "TEST@SOFTUNI.BG"
            };

            user.PasswordHash = hasher.HashPassword(user, "softuni");

            return user;
        }
    }  
}
