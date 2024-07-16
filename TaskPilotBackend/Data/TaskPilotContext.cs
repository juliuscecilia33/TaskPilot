using Microsoft.EntityFrameworkCore;
using TaskPilot.Models;

namespace TaskPilot.Data
{
    public class TaskPilotContext : DbContext
    {
        public TaskPilotContext(DbContextOptions<TaskPilotContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
