using System;
using System.Collections.Generic;

public class QuadraticProbing<T> : IHashTable<T>
  where T : IRegistry<T>
{
  public List<T> Content()
  {
    throw new NotImplementedException();
  }

  public bool Exists(T item, out int itemPosition)
  {
    throw new NotImplementedException();
  }

  public void Insert(T item)
  {
    throw new NotImplementedException();
  }

  public bool Remove(T item)
  {
    throw new NotImplementedException();
  }
}
