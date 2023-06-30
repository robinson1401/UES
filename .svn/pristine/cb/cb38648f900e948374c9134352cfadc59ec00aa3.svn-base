using Microsoft.Extensions.Hosting;

namespace UES.Models
{
    public class Nganh : AbstractEntity<Guid> // Ngành đào tạo
    {
        public string MaHDT { get; set; } // Required foreign key property
        public HeDaoTao HeDaoTao { get; set; } = null!; // Required reference navigation to principal
        public string MaNganh { get; set; } // Mã ngành đào tạo
        public string TenNganh { get; set; } // Tên ngành đào tạo
        public string MoTa { get; set; } // Mô tả ngành đào tạo
        public ICollection<ChuongTrinhDaoTao> ChuongTrinhDaoTaos { get; } = new List<ChuongTrinhDaoTao>(); // Collection navigation containing dependents
    }
}
