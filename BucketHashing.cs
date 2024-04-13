using System.Collections;
using System.Collections.Generic;

class BucketHashing<T> : IHashTable<T>
  where T : IRegistry<T>
{
    private const int SIZE = 131;
    private ArrayList[] data;

    public BucketHashing()
    {
        data = new ArrayList[SIZE];
        for (int i = 0; i < SIZE; i++)
            data[i] = new ArrayList(1);
    }

    public int Hash(string key)
    {
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash = hash % data.Length;
        return (int)hash;
    }

    public void Insert(T item)
    {
        int itemHashValue = Hash(item.Key);
        if (!data[itemHashValue].Contains(item))
            data[itemHashValue].Add(item);
    }

    public bool Remove(T item)
    {
        int itemPosition = 0;
        if (!Exists(item, out itemPosition))
            return false;
        data[itemPosition].Remove(item);
        return true;
    }

    public bool Exists(T item, out int itemPosition)
    {
        itemPosition = Hash(item.Key);
        return data[itemPosition].Contains(item);
    }

    public List<T> Content()
    {
        List<T> content = new List<T>();
        for (int i = 0; i < data.Length; i++)
            if (data[i].Count > 0)
                foreach (T item in data[i])
                    content.Add(item);
        return content;
    }
}
