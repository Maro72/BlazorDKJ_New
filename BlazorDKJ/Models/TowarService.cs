using Microsoft.EntityFrameworkCore;

namespace BlazorDKJ.Models
{
    public class TowarService : ITowarService
    {
        private mczeContext _context;
        public TowarService(mczeContext context)
        {
            _context = context;
        }
        public void DeleteTowar(int id)
        {
            try
            {
                tbtowar ord = _context.tbtowar.Find(id);
                _context.tbtowar.Remove(ord);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<tbtowar> GetTbtowar()
        {
            try
            {
                return _context.tbtowar.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertTowar(tbtowar tbtowar)
        {
            try
            {
                _context.tbtowar.Add(tbtowar);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public tbtowar SingleTowar(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTowar(long id, tbtowar tbtowar)
        {
            try
            {
                var local = _context.Set<tbtowar>().Local.FirstOrDefault(entry => entry.IDTowar.Equals(tbtowar.IDTowar));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(tbtowar).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
