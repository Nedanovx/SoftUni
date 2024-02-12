using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp.Data.Models;
using Task = TaskBoardApp.Data.Models.Task;
namespace TaskBoardApp.Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
               .HasOne(t => t.Board)
               .WithMany(b => b.Tasks)
               .HasForeignKey(t => t.BoardId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedTasks());
        }

        private IEnumerable<Task> SeedTasks()
        {
            return new Task[]
            {
                new Task()
                {
                Id = 1,
                Title = "Improve CCS style",
                Description = "Implement better styling for all public pages",
                CreatedOn = DateTime.Now.AddDays(-200),
                OwnerId = ConfigurationHelper.testUser.Id,
                BoardId = ConfigurationHelper.openBoard.Id
                },
                new Task()
                {
                    Id = 2,
                    Title = "Android Client App",
                    Description = "Create Android client app for the TaskBoard RESTful API",
                    CreatedOn = DateTime.Now. AddMonths(-5),
                    OwnerId = ConfigurationHelper.testUser.Id,
                    BoardId = ConfigurationHelper.openBoard.Id
                },
                new Task()
                {
                    Id = 3,
                    Title = "Desktop Client App",
                    Description = "Create Windows Forms desktop app client for the TaskBoard RESTful API",
                    CreatedOn = DateTime.Now.AddMonths(-1),
                    OwnerId = ConfigurationHelper.testUser.Id,
                    BoardId = ConfigurationHelper.inProgressBoard.Id
                },
                new Task()
                {
                Id = 4,
                Title = "Create Tasks",
                Description = "Implement [Create Task] page for adding new tasks",
                CreatedOn = DateTime.Now. AddYears(-1),
                OwnerId = ConfigurationHelper.testUser.Id,
                BoardId = ConfigurationHelper.doneBoard.Id
                }
            };
        }    
    }
}
