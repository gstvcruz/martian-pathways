using apCaminhosEmMarte;
using System;
using System.Collections;
using System.Collections.Generic;

  class BucketHash<Tipo> : ITabelaDeHash<Tipo>
    where Tipo : IRegistro<Tipo>
  {
    private const int SIZE = 131; // para gerar mais colisões; o ideal é primo > 100

    ArrayList[] dados;

    public BucketHash()
    {
      dados = new ArrayList[SIZE];
      for (int i = 0; i < SIZE; i++)
      {
        // coloca em cada posição do vetor, um arrayList vazio
        dados[i] = new ArrayList(1);
      }
    }

    public int Hash(string chave)
    {
      long tot = 0;
      for (int i = 0; i < chave.Length; i++)
        tot += 37 * tot + (char)chave[i];

      tot = tot % dados.Length;
      if (tot < 0)
        tot += dados.Length;
      return (int)tot;
    }

    public void Inserir(Tipo item)
    {
      int valorDeHash = Hash(item.Chave);
      if (!dados[valorDeHash].Contains(item))
        dados[valorDeHash].Add(item);
    }

    public bool Remover(Tipo item)
    {
      int onde = 0;
      if (!Existe(item, out onde))
         return false;

      dados[onde].Remove(item);
      return true;
    }

    public bool Existe(Tipo item, out int posicao)
    {
      posicao = Hash(item.Chave);
      return dados[posicao].Contains(item);
    }

    public List<Tipo> Conteudo()
    {
      List<Tipo> saida = new List<Tipo>();
      for (int i = 0; i < dados.Length; i++)
        if (dados[i].Count > 0)
        {
          foreach (Tipo item in dados[i])
            saida.Add(item);
        }
      return saida;
    }
  }
