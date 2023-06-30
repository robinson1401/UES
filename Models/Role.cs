using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UES.Models.Type;

namespace UES.Models
{
    public class Role : AbstractEntity<Guid>
    {
        public RoleType RoleType { get; set; }
        public string Description { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        [JsonIgnore]
        public ICollection<User> Users { get; } = new HashSet<User>();
    }
}
