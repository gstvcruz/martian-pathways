using System.Collections.Generic;

public class HashLinear<T> : ITabelaDeHash<T>
	where T : IRegistro<T>
{
	private const int SIZE = 101;
	private T[] dados;

	public HashLinear()
	{
		dados = new T[SIZE];
	}

	public int Hash(string chave)
	{
		long tot = 0;
		foreach (char c in chave)
			tot += 37 * tot + c;

		tot %= chave.Length;
		if (tot < 0)
			tot += chave.Length;
		
		int initial_pos = (int)tot;
		if (dados[initial_pos] == null) return initial_pos;
		
		int pos = initial_pos;
		bool hasReachedEnd = false;
		while (dados[pos] != null)
		{
			if (pos == dados.Length)
			{
				pos = 0;
				hasReachedEnd = true;
			}
			else if (pos == initial_pos && hasReachedEnd) return initial_pos;
			else pos++;
		}
		return pos;
	}

	public void Inserir(T item)
	{
		int pos;
		if (!Existe(item, out pos))
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
		return dados[pos] != null;
	}

	public List<T> Conteudo()
	{
		List<T> saida = new List<T>();
		foreach (T item in dados)
			if (item != null) saida.Add(item);
		return saida;
	}
}
