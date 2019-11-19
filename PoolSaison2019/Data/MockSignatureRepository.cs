using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoolSaison2019.Models;

namespace PoolSaison2019.Data
{
    public class MockSignatureRepository : IRepository<DerniereSignature>
    {
        private readonly List<DerniereSignature> _derniereSignature;
        public MockSignatureRepository()
        {
            _derniereSignature = new List<DerniereSignature>();
            {
                new DerniereSignature() { Id = 1, Nom = "Nom1", Equipe = "Equipe1", Salaire = 1 };
                new DerniereSignature() { Id = 2, Nom = "Nom2", Equipe = "Equipe1", Salaire = 2 };
                new DerniereSignature() { Id = 3, Nom = "Nom3", Equipe = "Equipe2", Salaire = 3 };
                new DerniereSignature() { Id = 4, Nom = "Nom4", Equipe = "Equipe3", Salaire = 4 };
                new DerniereSignature() { Id = 4, Nom = "Nom4", Equipe = "Equipe3", Salaire = 5 };
            };
        }
        public Task Add(DerniereSignature entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(DerniereSignature entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<DerniereSignature>> GetAll()
        {
            return _derniereSignature.AsQueryable();
        }

        public Task<DerniereSignature> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(DerniereSignature entity)
        {
            throw new NotImplementedException();
        }
    }
}
