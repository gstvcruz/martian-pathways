/*
 * 23513 - Diogo Lourenço
 * 23521 - Gustavo Cruz
*/

using System.Collections.Generic;

// Implements linear probing
public class LinearProbing<T> : IHashTable<T>
	where T : IRegistry<T>
{
	private const int SIZE = 131;
	private T[] data;

	public LinearProbing()
	{
		data = new T[SIZE];
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
		bool hasReachedEnd = false;
		// Loop over hash table positions looking for an empty spot
		while (data[currentPosition] != null)
		{
			// Hash table end was reached
			if (currentPosition == data.Length - 1)
			{
				currentPosition = 0;
				hasReachedEnd = true;
			}
			// No empty spot found after searching the entire hash table
			if ((currentPosition == initialPosition) && hasReachedEnd)
				 return initialPosition;
			// Keep looking for an empty spot
			else
				currentPosition++;
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
