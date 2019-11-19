using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoolSaison2019.Models;

namespace PoolSaison2019.Data
{
    public class MockParticipantRepository : IRepository<Participant>
    {
        private readonly List<Participant> _participant;
        public MockParticipantRepository()
        {
            _participant = new List<Participant>();
            {
                new Participant() { Id = 1, Nom = "Nom1", Gains = 1, Gains_totaux = 1, Points = 1, Rang = 1, Rang_semaine_passee = 1};
                new Participant() { Id = 2, Nom = "Nom2", Gains = 2, Gains_totaux = 2, Points = 2, Rang = 2, Rang_semaine_passee = 2};
                new Participant() { Id = 3, Nom = "Nom3", Gains = 3, Gains_totaux = 3, Points = 3, Rang = 3, Rang_semaine_passee = 3};
                new Participant() { Id = 4, Nom = "Nom4", Gains = 4, Gains_totaux = 4, Points = 4, Rang = 4, Rang_semaine_passee = 4};
            };
        }
        public Task Add(Participant entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Participant entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Participant>> GetAll()
        {
            return _participant.AsQueryable();
        }

        public Task<Participant> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Participant entity)
        {
            throw new NotImplementedException();
        }
    }
}
