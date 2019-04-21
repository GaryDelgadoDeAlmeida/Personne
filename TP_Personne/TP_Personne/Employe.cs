using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personne
{
    class Employe : Personne
    {
        protected double salaire;

        public Employe(string name, string lastName, DateTime dateNaiss, double salaire) : base(name, lastName, dateNaiss)
        {
            this.salaire = salaire;
        }

        public double getSalaire()
        {
            return this.salaire;
        }

        public override string ToString()
        {
            return "Nom : " + this.name + ",\nPrénom : " + this.lastName + ",\nDate de Naissance : " + this.dateNaiss + 
                ",\nSalaire : " + this.salaire;
        }
    }
}
