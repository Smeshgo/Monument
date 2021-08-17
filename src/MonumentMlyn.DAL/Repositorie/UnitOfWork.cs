using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Repositorie.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonumentMlyn.DAL.Repositorie
{
    /// <summary>
    /// Unit of Work pattern simplifies working with different repositories for getting data from repository.
    /// It Helps work with data context.
    /// </summary>
    class UnitOfWork : IUnitOfWork
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

        public UnitOfWork(ApplicationDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IAppointmentRepository Appointment
        {
            get
            {
                if (_appointmentRepository == null)
                    _appointmentRepository = new AppointmentRepository(_repositoryContext);
                return _appointmentRepository;
            }
        }

        public IArticleRepository Article
        {
            get
            {
                if (_articleRepository == null)
                    _articleRepository = new ArticleRepository(_repositoryContext);
                return _articleRepository;
            }
        }
        public ICategoryMaterialRepositorie CategoryMaterial
        {
            get
            {
                if (_categoryMaterialRepositorie == null)
                    _categoryMaterialRepositorie = new CategoryMaterialRepositorie(_repositoryContext);
                return _categoryMaterialRepositorie;
            }
        }
        public ICategoryPhotoRepositorie CategoryPhoto
        {
            get
            {
                if (_categoryPhotoRepositorie == null)
                    _categoryPhotoRepositorie = new CategoryPhotoRepositorie(_repositoryContext);
                return _categoryPhotoRepositorie;
            }
        }
        public ICustomerRepositorie Customer
        {
            get
            {
                if (_customerRepositorie == null)
                    _customerRepositorie = new CustomerRepositorie(_repositoryContext);
                return _customerRepositorie;
            }
        }
        public IMaterialRepositorie Material
        {
            get
            {
                if (_materialRepositorie == null)
                    _materialRepositorie = new MaterialRepositorie(_repositoryContext);
                return _materialRepositorie;
            }
        }
        public IMonumentRepositorie Monument
        {
            get
            {
                if (_monumentRepositorie == null)
                    _monumentRepositorie = new MonumentRepositorie(_repositoryContext);
                return _monumentRepositorie;
            }
        }
        public IPhotoRepositorie Photo
        {
            get
            {
                if (_photoRepositorie == null)
                    _photoRepositorie = new PhotoRepositorie(_repositoryContext);
                return _photoRepositorie;
            }
        }
        public IRoleRepositorie Role
        {
            get
            {
                if (_roleRepositorie == null)
                    _roleRepositorie = new RoleRepositorie(_repositoryContext);
                return _roleRepositorie;
            }
        }
        public IUserRepositorie User
        {
            get
            {
                if (_userRepositorie == null)
                    _userRepositorie = new UserRepositorie(_repositoryContext);
                return _userRepositorie;
            }
        }

        public IWorkerRepositorie Worker
        {
            get
            {
                if (_workerRepositorie == null)
                    _workerRepositorie = new WorkerRepositorie(_repositoryContext);
                return _workerRepositorie;
            }
        }


        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
