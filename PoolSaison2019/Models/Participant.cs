using System;
using System.ComponentModel.DataAnnotations;
using PoolSaison2019.Data;

namespace PoolSaison2019.Models
{
    public class Participant : Entity
    {
        public string Nom { get; set; }
        public int Gains { get; set; }
        public int Rang { get; set; }
        public int Rang_semaine_passee {get; set;}
        public int Points { get; set; }
        public int Gains_totaux { get; set; }
    }
}
