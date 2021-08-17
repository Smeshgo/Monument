using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie
{
    interface IUnitOfWork
    {
        IAppointmentRepository Appointment { get; }
        IArticleRepository Article { get; }
        ICategoryMaterialRepositorie CategoryMaterial { get; }
        ICategoryPhotoRepositorie CategoryPhoto { get; }
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
