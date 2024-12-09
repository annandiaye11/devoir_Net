namespace DevoirNet.Core;

public interface IRepository <T>
{
    List<T> SelectAll ();
}