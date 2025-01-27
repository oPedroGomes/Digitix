using Digitix.Platform.Core.Courses;
using Microsoft.EntityFrameworkCore;

namespace Digitix.Platform.Infrastructure;

public class CourseContext : DbContext
{
    DbSet<Course> Courses { get; set; }
    
    
    
    public CourseContext(DbContextOptions<CourseContext> options) : base(options)
    {
        
    }
    
}