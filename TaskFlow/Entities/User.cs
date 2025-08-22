using Microsoft.AspNetCore.Identity;

namespace TaskFlow.Entities
{
    public class User : IdentityUser
    {
        public string Role { get; set; }
        public string AvatarURL { get; set; }
        public TimeZone TimeZone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
