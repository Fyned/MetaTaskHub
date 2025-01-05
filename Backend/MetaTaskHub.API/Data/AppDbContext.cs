// AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using MetaTaskHub.API.Models;

// Alias the Task model to avoid ambiguity with System.Threading.Tasks.Task
using TaskModel = MetaTaskHub.API.Models.Task;

namespace MetaTaskHub.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<TaskModel> Tasks { get; set; } = null!; // Using the alias here
        public DbSet<AI_Suggestion> AI_Suggestions { get; set; } = null!;
    }
}
