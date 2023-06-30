using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UES.Models
{
    public abstract class AbstractEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActivated { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public string? CreatedBy { get; set; }
        [JsonIgnore]
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        [JsonIgnore]
        public string? LastModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime DeletedDate { get; set; }
        [JsonIgnore]
        public string? DeletedBy { get; set; }
    }
}
