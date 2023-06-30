using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UES.Models.Type;

namespace UES.Models
{
    [Table("Permission")]
    public class Permission : AbstractEntity<Guid>
    {
        public PermissionType PermissionType { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Role> Roles { get; } = new HashSet<Role>();
        [JsonIgnore]
        public ICollection<User> Users { get; } = new HashSet<User>();
    }
}
