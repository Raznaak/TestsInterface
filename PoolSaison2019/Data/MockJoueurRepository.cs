using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoolSaison2019.Models;

namespace PoolSaison2019.Data
{
    public class MockJoueurRepository: IRepository<Joueur>
    {
        private readonly List<Joueur> _joueurs;
        public MockJoueurRepository()
        {
            _joueurs = new List<Joueur>()
            {
                new Joueur() { Id = 1, Nom = "Nom1", Equipe = "Equipe1", Position = "Position1", Salaire = 1 },
                new Joueur() { Id = 2, Nom = "Nom2", Equipe = "Equipe1", Position = "Position2", Salaire = 2 },
                new Joueur() { Id = 3, Nom = "Nom3", Equipe = "Equipe2", Position = "Position1", Salaire = 3 },
            };
        }

        public async Task Add(Joueur entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Joueur entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Joueur>> GetAll()
        {

            IQueryable<Joueur> list = _joueurs.AsQueryable();
            return await Task.Run(() => list);
            //return await Task.FromResult(_joueurs.AsQueryable());
            //return _joueurs.AsQueryable();
        }

        public Task<Joueur> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Joueur entity)
        {
            throw new NotImplementedException();
        }
    }
}
