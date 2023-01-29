namespace BlazorDKJ.Models
{
    public interface ITowarService
    {
        IEnumerable<tbtowar> GetTbtowar();
        void InsertTowar(tbtowar tbtowar);
        void UpdateTowar(long id, tbtowar tbtowar);
        tbtowar SingleTowar(long id);
        void DeleteTowar(int id);
    }
}
