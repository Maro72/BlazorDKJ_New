namespace BlazorDKJ.Models
{
    public interface IJmService
    {
        IEnumerable<tbjm> GetTbjm();
        void InsertJm(tbjm tbjm);
        void UpdateJm(long id, tbjm tbjm);
        tbjm SingleJm(long id);
        void DeleteJm(int id);

    }
}
