using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IUnitOfWork
    {
        IArticleRepository Article { get; }
        IMaterialRepositorie Material { get; }
        IMonumentRepositorie Monument { get; }
        IPhotoRepositorie Photo { get; }
        IWorkerRepositorie Worker { get; }
        ICustomerRepositorie Customer { get; }
        ISalaryRepositorie Salary { get; }
        
        Task SaveAsync();

    }
}
