using System.Collections.Generic;

public interface IHashTable<T>
  where T : IRegistry<T>
{
    void Insert(T item);
    bool Remove(T item);
    bool Exists(T item, out int itemPosition);
    List<T> Content();
}
