using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personne
{
    class Personne
    {
        protected string name;
        protected string lastName;
        protected DateTime dateNaiss;

        public Personne(string name, string lastName, DateTime dateNaiss)
        {
            this.name = name;
            this.lastName = lastName;
            this.dateNaiss = dateNaiss;
        }

        public string getName()
        {
            return this.name;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public DateTime getDateNaiss()
        {
            return this.dateNaiss;
        }

        public override string ToString()
        {
            return "Nom : " + this.name + "\nPrénom : " + this.lastName + "\nDate de Naissance : " + this.dateNaiss;
        }
    }
}
