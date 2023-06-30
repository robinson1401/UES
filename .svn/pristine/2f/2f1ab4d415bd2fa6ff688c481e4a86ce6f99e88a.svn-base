namespace UES.Models
{
    public class ChuongTrinhDaoTao : AbstractEntity<Guid> // Chương trình đào tạo
    {
        public string? MaNganh { get; set; } // Optional foreign key property
        public Nganh? Nganh { get; set; } // Optional reference navigation to principal
        public string TenNganh { get; set; } // Tên ngành đào tạo
        public string MaCTDT { get; set; } // Mã CTDT
        public string TenCTDT { get; set; } // Tên CTĐT
        public string LoaiBang { get; set; } // Loại bằng
        public string ThoiGianDaoTao { get; set; } // Thời gian đào tạo
        public string ChuanDauRa { get; set; } // Chuẩn đầu ra
        public ICollection<HocPhan> HocPhans { get; } = new List<HocPhan>(); // Collection navigation containing dependents
    }
}
