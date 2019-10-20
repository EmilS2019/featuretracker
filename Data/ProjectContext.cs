using Microsoft.EntityFrameworkCore;

namespace featuretracker.Models
{
    public class ProjectsContext : DbContext
    {
        public ProjectsContext(DbContextOptions<ProjectsContext> options)
        : base(options)
        {
            
        }

        public DbSet<Project> Project {get; set;}
    }
}