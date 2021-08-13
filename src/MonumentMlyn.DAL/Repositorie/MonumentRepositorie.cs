using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonumentMlyn.DAL.EF;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.DAL.Repositorie
{
    class MonumentRepositorie : RepositoryBase<Monument>, IMonumentRepositorie
    {
        public MonumentRepositorie(ApplicationDbContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Monument>> GetAllMonuments(bool trackChanges) =>
            await FindAll(trackChanges)
                .OrderBy(c => c.Prise)
                .ToListAsync();

        public async Task<Monument> GetMonumentById(int idMonument)
        {
            return await FindByCondition(x => x.IdMonument.Equals(idMonument))
                .FirstOrDefaultAsync();
        }

        public Monument GetMonumentWithDetails(int idMonument)
        {
            return FindByCondition(owner => owner.IdMonument.Equals(idMonument)).FirstOrDefault();
        }
        public void CreateMonument(Monument monument)
        {
            Create(monument);
        }
        public void UpdateMonument(Monument monument)
        {
            Update(monument);
        }

        public void DeleteMonument(Monument monument)
        {
            Delete(monument);
        }

       

        
    }
}
