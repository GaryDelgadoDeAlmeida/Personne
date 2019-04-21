using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------------------------------------------------------\n"
                + "\t\tHéritage & Polymorphisme de la classe Personne" +
                "\n-------------------------------------------------------------------------\n");
            List<Personne> listPersonne = new List<Personne>();
            Personne e1, e2, e3, e4, e5, c1, c2, d;
            e1 = new Employe("DUBOIS", "Luc", new DateTime(2019, 1, 1), 1900);
            e2 = new Employe("ALMEIDA", "Gary", new DateTime(1999, 2, 28), 1500);
            e3 = new Employe("DELGADO", "Mathieu", new DateTime(1997, 2, 25), 1500);
            e4 = new Employe("GIRAUD", "Olivier", new DateTime(2001, 1, 1), 1700);
            e5 = new Employe("DUROI", "Mathieu", new DateTime(1997, 1, 1), 1900);
            c1 = new Chef("RICHARD", "Jacque", new DateTime(1995, 1, 1), 2500, "Chef de Projet");
            c2 = new Chef("MOREAU", "Etienne", new DateTime(1990, 1, 1), 2500, "Chef de Projet");
            d = new Directeur("CHEVALIER", "Henri", new DateTime(1899, 1, 1), 3000, "Directeur", "Expert SSII");

            listPersonne.Add(e1);
            listPersonne.Add(e2);
            listPersonne.Add(e3);
            listPersonne.Add(e4);
            listPersonne.Add(e5);
            listPersonne.Add(c1);
            listPersonne.Add(c2);
            listPersonne.Add(d);

            printTableWithFor(listPersonne);
            printTableWithForeach(listPersonne);

            Console.ReadLine();
        }

        private static void printTableWithFor(List<Personne> lesPersonnes)
        {
            Console.WriteLine("\nAffichage de la liste d'objets Personne à l'aide d'une bouble for\n");
            for(int i = 0; i < lesPersonnes.Count; i++)
            {
                Console.WriteLine(lesPersonnes[i].ToString());
                Console.WriteLine("\n--------------------------------------------------\n");
            }
        }

        private static void printTableWithForeach(List<Personne> lesPersonnes)
        {
            Console.WriteLine("\nAffichage de la liste d'objets Personne à l'aide d'une boucle foreach\n");
            foreach(Personne unePersonne in lesPersonnes)
            {
                Console.WriteLine(unePersonne.ToString());
                Console.WriteLine("\n--------------------------------------------------\n");
            }
        }
    }
}
