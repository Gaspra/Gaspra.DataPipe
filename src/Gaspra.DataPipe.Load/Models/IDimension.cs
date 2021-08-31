namespace Gaspra.DataPipe.Load.Models
{
    public interface IDimension<out F> where F : class, IFact
    {
        F Fact { get; }
    }
}
