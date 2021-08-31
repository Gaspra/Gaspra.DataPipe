namespace Gaspra.DataPipe.Load.Models
{
    public interface ILookup<out T>
    {
        T Value { get; }
    }
}
