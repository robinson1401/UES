
using UES.Data;
using UES.Interfaces;
using UES.Models;

namespace UES.Repository
{
    public class DauDiemRepository : DauDiemServiec
    {
        private readonly UESContext _context;

        public DauDiemRepository( UESContext context)
        {
            _context = context;
        }

        public ICollection<DauDiem> GetDauDiems()
        {
            return _context.DauDiem.OrderBy(d => d.Id).ToList();
        }
    }
}
