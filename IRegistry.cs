using System.IO;

public interface IRegistry<T>
{
  void ReadRegistry(StreamReader file);
  void WriteData(StreamWriter file);
  string Key { get; }
}
