using System.IO;

public interface IRegistro<Tipo>
{
  void LerRegistro(StreamReader arquivo);
  void GravarDados(StreamWriter arquivo);
  string Chave { get; }
}
