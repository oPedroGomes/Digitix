namespace Digitix.Platform.Core.Courses;

public class Course
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Guid OwnerId { get; private set; }
    public DateTime CreationDate { get; private set; }
    
    
}