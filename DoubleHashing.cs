using System;
using System.Collections.Generic;

public class DoubleHashing<T> : IHashTable<T>
    where T : IRegistry<T>
{
    private T[] data;
    private int size;

    public DoubleHashing(int capacity)
    {
        data = new T[capacity];
        size = capacity;
    }

    public int Hash(string key)
    {
        long hash = 0;
		foreach (char c in key)
			hash += 37 * hash + c;
		hash %= data.Length;
		if (hash < 0)
			hash += data.Length;
		
		int initialPosition = (int)hash;
		int currentPosition = initialPosition;
        int numCallHash = 1;
		bool hasReachedEnd = false;
		// Loop over hash table positions looking for an empty spot
		while (data[currentPosition] != null)
		{
            // No empty spot found after searching the entire hash table
            if ((currentPosition == initialPosition) && hasReachedEnd)
                break;
            // Hash table end was reached
            if (currentPosition >= data.Length - 1)
			{
                if (data[0] == null)
                {
                    currentPosition = 0;
                    break;
                }
				
				
                numCallHash += 1; 
                currentPosition = 1 + numCallHash;
				hasReachedEnd = true;
				continue;
			}
            else
			    // Keep looking for an empty spot
			    currentPosition *= 2;
            
		}
		return currentPosition;
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