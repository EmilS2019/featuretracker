using Microsoft.EntityFrameworkCore;

namespace featuretracker.Models
{
    public class ProjectsContext : DbContext
    {
        public ProjectsContext(DbContextOptions<ProjectsContext> options)
        : base(options)
        {
            
        }

        public DbSet<featuretracker.Models.Project> Project {get; set;}
    }
}