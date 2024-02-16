using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp.Data.Models;
using Task = TaskBoardApp.Data.Models.Task;


namespace TaskBoardApp.Data.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        


        public void Configure(EntityTypeBuilder<Task> modelBuilder)
        {
            modelBuilder
               .HasOne(t => t.Board)
               .WithMany(b => b.Tasks)
               .HasForeignKey(t => t.BoardId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.HasData(SeedTasks()); 
        }

        private IEnumerable<Task> SeedTasks()
        {

            return new Task[]
            {
                new Task 
                { 
                    Id = 1, 
                    Title = "Buy groceries", 
                    Description = "Get milk, eggs, and bread", 
                    CreatedOn = DateTime.UtcNow.AddDays(-200), 
                    OwnerId = ConfigurationHelper.TestUser.Id, 
                    BoardId = ConfigurationHelper.OpenBoard.Id 
                },
                new Task 
                { 
                    Id = 2, 
                    Title = "Finish report", 
                    Description = "Due next week",
                    CreatedOn = DateTime.UtcNow.AddDays(-100),
                    OwnerId = ConfigurationHelper.TestUser.Id,
                    BoardId = ConfigurationHelper.OpenBoard.Id
                },
                new Task 
                { 
                    Id = 3, 
                    Title = "Call Mom",
                    Description = "Haven't talked in a while",
                    CreatedOn = DateTime.UtcNow.AddDays(-50),
                    OwnerId = ConfigurationHelper.TestUser.Id,
                    BoardId = ConfigurationHelper.OpenBoard.Id
                },
                new Task 
                { 
                    Id = 4, 
                    Title = "Plan vacation", 
                    Description = "Need to book flights and hotels",
                    CreatedOn = DateTime.UtcNow,
                    OwnerId = ConfigurationHelper.TestUser.Id,
                    BoardId = ConfigurationHelper.OpenBoard.Id
                }
            };


        }




    }
}
