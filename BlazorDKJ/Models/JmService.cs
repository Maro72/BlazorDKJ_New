namespace BlazorDKJ.Models
{
    public class JmService : IJmService
    {
        private mczeContext _context;
        public JmService(mczeContext context)
        {
            _context = context;
        }
        public void DeleteJm(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbjm> GetTbjm()
        {
            try
            {
                return _context.tbjm.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertJm(tbjm tbjm)
        {
            throw new NotImplementedException();
        }

        public tbjm SingleJm(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateJm(long id, tbjm tbjm)
        {
            throw new NotImplementedException();
        }
    }
}
