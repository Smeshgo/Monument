using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    /// <summary>
    /// Unit of Work pattern simplifies working with different repositories for getting data from repository.
    /// It Helps work with data context.
    /// </summary>
    public class UnitOfWorkImpl : IUnitOfWork
    {
        
        private readonly ApplicationDbContext _repositoryContext;
        private IAppointmentRepository _appointmentRepository;
        private IArticleRepository _articleRepository;
        private ICategoryMaterialRepositorie _categoryMaterialRepositorie;
        private ICategoryPhotoRepositorie _categoryPhotoRepositorie;
        private ICustomerRepositorie _customerRepositorie;
        private IMaterialRepositorie _materialRepositorie;
        private IMonumentRepositorie _monumentRepositorie;
        private IPhotoRepositorie _photoRepositorie;
        private IRoleRepositorie _roleRepositorie;
        private IUserRepositorie _userRepositorie;
        private IWorkerRepositorie _workerRepositorie;

        public UnitOfWorkImpl(ApplicationDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IAppointmentRepository Appointment
        {
            get
            {
                if (_appointmentRepository == null)
                    _appointmentRepository = new AppointmentRepositoryImpl(_repositoryContext);
                return _appointmentRepository;
            }
        }

        public IArticleRepository Article
        {
            get
            {
                if (_articleRepository == null)
                    _articleRepository = new ArticleRepositoryImpl(_repositoryContext);
                return _articleRepository;
            }
        }
        public ICategoryMaterialRepositorie CategoryMaterial
        {
            get
            {
                if (_categoryMaterialRepositorie == null)
                    _categoryMaterialRepositorie = new CategoryMaterialRepositorieImpl(_repositoryContext);
                return _categoryMaterialRepositorie;
            }
        }
        public ICategoryPhotoRepositorie CategoryPhoto
        {
            get
            {
                if (_categoryPhotoRepositorie == null)
                    _categoryPhotoRepositorie = new CategoryPhotoRepositorieImpl(_repositoryContext);
                return _categoryPhotoRepositorie;
            }
        }
        public ICustomerRepositorie Customer
        {
            get
            {
                if (_customerRepositorie == null)
                    _customerRepositorie = new CustomerRepositorieImpl(_repositoryContext);
                return _customerRepositorie;
            }
        }
        public IMaterialRepositorie Material
        {
            get
            {
                if (_materialRepositorie == null)
                    _materialRepositorie = new MaterialRepositorieImpl(_repositoryContext);
                return _materialRepositorie;
            }
        }
        public IMonumentRepositorie Monument
        {
            get
            {
                if (_monumentRepositorie == null)
                    _monumentRepositorie = new MonumentRepositorieImpl(_repositoryContext);
                return _monumentRepositorie;
            }
        }
        public IPhotoRepositorie Photo
        {
            get
            {
                if (_photoRepositorie == null)
                    _photoRepositorie = new PhotoRepositorieImpl(_repositoryContext);
                return _photoRepositorie;
            }
        }
        public IRoleRepositorie Role
        {
            get
            {
                if (_roleRepositorie == null)
                    _roleRepositorie = new RoleRepositorieImpl(_repositoryContext);
                return _roleRepositorie;
            }
        }
        public IUserRepositorie User
        {
            get
            {
                if (_userRepositorie == null)
                    _userRepositorie = new UserRepositorieImpl(_repositoryContext);
                return _userRepositorie;
            }
        }

        public IWorkerRepositorie Worker
        {
            get
            {
                if (_workerRepositorie == null)
                    _workerRepositorie = new WorkerRepositorieImpl(_repositoryContext);
                return _workerRepositorie;
            }
        }


        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
