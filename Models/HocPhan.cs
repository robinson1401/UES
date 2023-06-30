﻿using Microsoft.Build.Framework;
using Microsoft.Extensions.Hosting;

namespace UES.Models
{
    public class HocPhan : AbstractEntity<Guid>
    {
        [Required]
        public string MaHocPhan { get; set; }
        [Required]
        public string TenHocPhan { get; set; }
        public string MaHocPhanTienQuyet { get; set; }
        public string TenHocPhanTienQuyet { get; set; }
        [Required]
        public string MaBoMon { get; set; }
        [Required]
        public string TenBoMon { get; set; }
        public int HocKy { get; set; }
        public string HocKyChu { get; set; }
        public int SoTinChi { get; set; }
        public string SoTinChiChu { get; set; }
        public string LoaiHocPhan { get; set; } // hoc phan bat buoc / hoc phan tu chon
        public string ThoiGianHoc { get; set; }
        public string MoTa { get; set; }
        public virtual ICollection<DauDiem>? DauDiems { get; } = new List<DauDiem>();
        public string MaCTDT { get; set; } // Required foreign key property
        public ChuongTrinhDaoTao ChuongTrinhDaoTao { get; set; } = null!; // Required reference navigation to principal

    }
}
