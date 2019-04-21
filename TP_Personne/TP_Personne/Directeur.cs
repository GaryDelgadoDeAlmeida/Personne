using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personne
{
    class Directeur : Chef
    {
        protected string societe;

        public Directeur(string name, string lastName, DateTime dateNaiss, double salaire, string service, string societe) : base(name, lastName, dateNaiss, salaire, service)
        {
            this.societe = societe;
        }

        public string getSociete()
        {
            return this.societe;
        }

        public override string ToString()
        {
            return "Nom : " + this.name + "\nPrénom : " + this.lastName + "\nDate de Naissance : " + this.dateNaiss
                + "\nSalaire : " + this.salaire + "\nService : " + this.service + "\nSociété : " + this.societe;
        }
    }
}
