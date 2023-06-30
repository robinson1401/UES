namespace UES.Models
{
    public class HeDaoTao : AbstractEntity<Guid> // Hệ đào tạo
    {
        public string MaHDT { get; set; } // Mã hệ đào tạo
        public string TenHDT { get; set; } // Tên hệ đào tạo
        public string MoTa { get; set; } // Mô tả hệ đào tạo
        public ICollection<Nganh> Nganhs { get; } = new List<Nganh>(); // Collection navigation containing dependents
    }
}
