namespace MyErp.Business.Interfaces;

public interface IGenericRepository<T>
{
    void Create(T element);
    IEnumerable<T> GetAll();
}