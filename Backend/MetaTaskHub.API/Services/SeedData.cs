using MetaTaskHub.API.Data;
using MetaTaskHub.API.Models;
using Microsoft.EntityFrameworkCore;

// Alias the Task model to avoid ambiguity with System.Threading.Tasks.Task
using TaskModel = MetaTaskHub.API.Models.Task;

namespace MetaTaskHub.API.Services
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Tasks.Any())
            {
                return; // DB has been seeded
            }

            context.Tasks.AddRange(
                new TaskModel
                {
                    Title = "Learn Blazor",
                    Description = "Complete Blazor project",
                    Priority = "High",
                    Status = "In Progress"
                },
                new TaskModel
                {
                    Title = "Learn ASP.NET Core",
                    Description = "Build an API",
                    Priority = "Medium",
                    Status = "Pending"
                }
            );

            context.SaveChanges();
        }
    }
}
