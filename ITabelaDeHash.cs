using System.Collections.Generic;

namespace apCaminhosEmMarte
{
  public interface ITabelaDeHash<Tipo>
      where Tipo : IRegistro<Tipo>
  {
    void Inserir(Tipo item);
    bool Remover(Tipo item);
    bool Existe(Tipo item, out int onde);
    List<Tipo> Conteudo();
  }
}
