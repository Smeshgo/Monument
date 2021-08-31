using System.Threading.Tasks;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    public interface IUnitOfWork
    {
        IArticleRepository Article { get; }
        IMaterialRepositorie Material { get; }
        IMonumentRepositorie Monument { get; }
        IPhotoRepositorie Photo { get; }
        IRoleRepositorie Role { get; }
        IUserRepositorie User { get; }
        IWorkerRepositorie Worker { get; }
        ICustomerRepositorie Customer { get; }
        Task SaveAsync();
        
    }
}
