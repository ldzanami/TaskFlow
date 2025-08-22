using System.Diagnostics.Contracts;

namespace TaskFlow.Entities
{
    public class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string ChatId { get; set; }
        public Chat Chat { get; set; }
        public List<ProjectMember> ProjectMembers { get; set; } = [];
        public User Owner { get; set; }
    }
}
