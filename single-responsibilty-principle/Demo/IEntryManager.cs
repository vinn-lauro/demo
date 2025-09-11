namespace Demo;

public interface IEntryManager<T>
{
    void Add(T entity);
    void Remove(int index);
}



