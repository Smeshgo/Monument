using MonumentMlyn.DAL.EF;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie.Impl
{
    /// <summary>
    /// Unit of Work pattern simplifies working with different repositories for getting data from repository.
    /// It Helps work with data context.
    /// </summary>
    public class UnitOfWorkImpl : IUnitOfWork
    {

        private readonly ApplicationDbContext _repositoryContext;
        private IArticleRepository _articleRepository;
        private ICustomerRepositorie _customerRepositorie;
        private IMaterialRepositorie _materialRepositorie;
        private IMonumentRepositorie _monumentRepositorie;
        private IPhotoRepositorie _photoRepositorie;
        private IRoleRepositorie _roleRepositorie;
        private IUserRepositorie _userRepositorie;
        private IWorkerRepositorie _workerRepositorie;
        private ISalaryRepositorie _calculationsRepositorie;

        public UnitOfWorkImpl(ApplicationDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
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

        public ISalaryRepositorie Salary
        {
            get
            {
                if (_calculationsRepositorie == null)
                    _calculationsRepositorie = new SalaryRepositorieImpl(_repositoryContext);
                return _calculationsRepositorie;
            }
        }
        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
