using Microsoft.EntityFrameworkCore;

namespace TaskFlow.Entities
{
    [PrimaryKey(nameof(MemberId), nameof(ProjectId))]
    public class ProjectMember
    {
        public string MemberId { get; set; }
        public string ProjectId { get; set; }
        public string Role { get; set; }
        public DateTime JoinedAt { get; set; }
        public DateTime LeavedAt { get; set; }
        public User Member { get; set; }
        public Project Project { get; set; }
    }
}
