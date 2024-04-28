/*
 * 23513 - Diogo Lourenço
 * 23521 - Gustavo Cruz
*/

using System.Collections;
using System.Collections.Generic;

// Implements a hash table with ArrayLists as hash buckets
class BucketHashing<T> : IHashTable<T>
  where T : IRegistry<T>
{
    private const int SIZE = 131;
    private ArrayList[] data;

    public BucketHashing()
    {
        // Instantiates the hash table
        data = new ArrayList[SIZE];
        for (int i = 0; i < SIZE; i++)
            data[i] = new ArrayList(1);
    }

    public int Hash(string key)
    {
        // Calulcates a hash for a key based on Horner's method
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash %= data.Length;
        if (hash < 0)
            hash += data.Length;
        return (int)hash;
    }

    public void Insert(T item)
    {
        // Insert an item if not already
        int itemPosition;
        if (!Exists(item, out itemPosition))
            data[itemPosition].Add(item);
    }

    public bool Remove(T item)
    {
        // Removes an item if found
        int itemPosition;
        if (!Exists(item, out itemPosition))
            return false;
        data[itemPosition].Remove(item);
        return true;
    }

    public bool Exists(T item, out int itemPosition)
    {
        // Checks whether an item exists
        itemPosition = Hash(item.Key);
        return data[itemPosition].Contains(item);
    }

    public List<T> Content()
    {
        // Lists the contents for each bucket that has at least one value
        List<T> content = new List<T>();
        foreach (ArrayList bucket in data)
            if (bucket.Count > 0)
                foreach (T item in bucket)
                    content.Add(item);
        return content;
    }
}
