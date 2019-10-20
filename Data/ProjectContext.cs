using Microsoft.EntityFrameworkCore;
using featuretracker.Models;

namespace featuretracker.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
        {
            
        }

        public DbSet<Project> Project {get; set;}
    }
}