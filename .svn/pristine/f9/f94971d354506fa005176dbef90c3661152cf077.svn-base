using System.ComponentModel.DataAnnotations.Schema;

namespace UES.Models
{
    [Table("DauDiem")]
    public class DauDiem : AbstractEntity<Guid>
    {   
        public string TenDiem { get; set; }
        public string ThanhPhanDiem { get; set; }
        public long DiemHeBon { get; set; }
        public string DiemHeBonBangChu { get; set; }
        public long DiemHeMuoi { get; set; }
        public string DiemHeMuoiBangChu { get; set; }
        public long DiemQuyDoi { get; set; }
        public long DiemToiThieuQuaMon { get; set; }
        public string MoTa { get; set; }
        public Guid? HocPhanId { get; set; }
        public virtual HocPhan? HocPhan { get; set; } = null!;
    }
}
