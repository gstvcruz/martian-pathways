/*
 * 23513 - Diogo Lourenço
 * 23521 - Gustavo Cruz
*/

using System;
using System.Collections.Generic;

// Implements quadratic probing
public class QuadraticProbing<T> : IHashTable<T>
    where T : IRegistry<T>
{
    private const int SIZE = 131;
    private T[] data;

    public QuadraticProbing()
    {
        data = new T[SIZE];
    }

    public int Hash(string key)
    {
        long hash = 0;
        foreach (char c in key)
            hash += 37 * hash + c;
        hash %= SIZE;
        if (hash < 0)
            hash += SIZE;

        int initialPosition = (int)hash;
        if ((data[initialPosition] == null) || (Content().Count >= SIZE / 2))
            return initialPosition;

        double currentPosition = initialPosition;
        double collisions = 1;
        // Loop over hash table positions looking for an empty spot
        while (data[(int)currentPosition] != null)
        {
            // Keep looking for an empty spot
            currentPosition = (currentPosition + Math.Pow(currentPosition, collisions++)) % SIZE;
            if (currentPosition % SIZE >= SIZE)
                return initialPosition;
        }
        return (int)currentPosition;
    }

    public void Insert(T item)
    {
        int itemHashValue;
        if (!Exists(item, out itemHashValue))
            data[itemHashValue] = item;
    }

    public bool Remove(T item)
    {
        int itemPosition;
        if (!Exists(item, out itemPosition))
            return false;
        data[itemPosition] = default;
        return true;
    }

    public bool Exists(T item, out int itemPosition)
    {
        itemPosition = Hash(item.Key);
        return data[itemPosition] != null;
    }

    public List<T> Content()
    {
        List<T> content = new List<T>();
        foreach (T item in data)
            if (item != null)
                content.Add(item);
        return content;
    }  
}
