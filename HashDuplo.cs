using System;
using System.Collections.Generic;

namespace apCaminhosEmMarte
{
  public class HashDuplo<Tipo> : ITabelaDeHash<Tipo>
    where Tipo : IRegistro<Tipo>
  {
    public List<Tipo> Conteudo()
    {
      throw new NotImplementedException();
    }

    public bool Existe(Tipo item, out int onde)
    {
      throw new NotImplementedException();
    }

    public void Inserir(Tipo item)
    {
      throw new NotImplementedException();
    }

    public bool Remover(Tipo item)
    {
      throw new NotImplementedException();
    }
  }
}
