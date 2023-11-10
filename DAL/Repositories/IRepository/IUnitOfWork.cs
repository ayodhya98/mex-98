namespace DAL.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product  { get; }

        void SaveAsync();
    }
}
