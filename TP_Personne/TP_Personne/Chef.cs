using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personne
{
    class Chef : Employe
    {
        protected string service;

        public Chef(string name, string lastName, DateTime dateNaiss, double salaire, string service) : base(name, lastName, dateNaiss, salaire)
        {
            this.service = service;
        }

        public string getService()
        {
            return this.service;
        }

        public override string ToString()
        {
            return "Nom : " + this.name + "\nPrénom : " + this.lastName + "\nDate de Naissance : " + this.dateNaiss 
                + "\nSalaire : " + this.salaire + "\nService : " + this.service;
        }
    }
}
