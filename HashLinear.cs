using System;
using System.Collections.Generic;

public class HashLinear<T> : ITabelaDeHash<T>
	where T : IRegistro<T>
{
	private const int SIZE = 1001;
	private T[] dados;

	public HashLinear()
	{
		dados = new T[SIZE];
	}

	public int Hash(string chave)
	{
		long hash = 0;
		foreach (char c in chave)
			hash += 37 * hash + c;

		hash %= chave.Length;
		if (hash < 0)
			hash += chave.Length;
		return (int)hash;
	}

	public void Inserir(T item)
	{
		int initial_pos = Hash(item.Chave);
		int pos = initial_pos;
		bool hasReachedEnd = false;
		while (dados[pos] != null)
		{
			if (pos == dados.Length)
			{
				pos = 0;
				hasReachedEnd = true;			
			} else if (pos == initial_pos && hasReachedEnd == true) return;
			else pos++;
		}
		dados[pos] = item;
	}

	public bool Remover(T item)
	{
		int pos;
		if (Existe(item, out pos))
		{
			dados[pos] = default;
			return true;
		}
		return false;
	}

	public bool Existe(T item, out int pos)
	{
		pos = Hash(item.Chave);
		if (dados[pos] != null) return true;
		else return false;
	}

	public List<T> Conteudo()
	{
		List<T> saida = new List<T>();
		foreach (T item in dados)
			if (item != null) saida.Add(item);
		return saida;
	}
}
