using UES.Models;
namespace UES.Interfaces
{
    public interface DauDiemServiec
    {
        public ICollection<DauDiem> GetDauDiems();

        //public object GetDauDiem { get; internal set; }
    }
}
