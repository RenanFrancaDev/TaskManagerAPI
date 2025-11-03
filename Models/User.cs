namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } 
        public DateTime CreatedAt { get; set; }

        // Relacionamento: 1 User tem N Tasks
        public List<Task> Tasks { get; set; }
    }
}