using System.Collections.Generic;

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
		long tot = 0;
		foreach (char c in key)
			tot += 37 * tot + c;
		tot %= key.Length;
		
		int initialPosition = (int)tot;
		if (data[initialPosition] == null)
			return initialPosition;

		int currentPosition = initialPosition;
		bool hasReachedEnd = false;
		// Loop over data positions looking for an empty spot
		while (data[currentPosition] != null)
		{
			if (currentPosition == data.Length)
			{
				currentPosition = 0;
				hasReachedEnd = true;
			}
			else if ((currentPosition == initialPosition) && hasReachedEnd)
				 return initialPosition;
			else
				currentPosition++;
		}
		return currentPosition;
	}

	public void Insert(T item)
	{
		int itemPosition;
		if (!Exists(item, out itemPosition))
			data[itemPosition] = item;
	}

	public bool Remove(T item)
	{
		int itemPosition;
		if (Exists(item, out itemPosition))
		{
			data[itemPosition] = default;
			return true;
		}
		return false;
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
