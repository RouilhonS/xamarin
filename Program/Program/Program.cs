using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace cours_C_Sharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            double ex1 = 12 + 5 * 12.5 - 1253.68;
            Console.WriteLine("Le résulat est : " + ex1);

            double moyenne = (1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5;
            Console.WriteLine("La moyenne de la liste: " + moyenne);

            List<string> fruit = new List<string>() { "Banane", "Pamplemousse", "Kiwi", "Framboise", "Fraise"};
            foreach (string texte in fruit.ToList())
            {
                if (texte.Contains("Banane"))
                {
                    fruit.Remove(texte);
                    Console.WriteLine("supprimé : " + texte);
                }
            }
            fruit.ForEach(w => Console.WriteLine(w));
            */

            int nombre = 0;
            Console.WriteLine("Entrez un nombre pour X : ");
            nombre = (int.Parse(Console.ReadLine()));
            for (int i = 0; i < nombre; i++)
            {
                int resultat = i + i;
                Console.WriteLine("Le résultat est : " + resultat + " pour avoir choisie le chiffre : " + nombre);
            }

        }
    }

    /*
    public class compteBancaire
    {
        private string b_titulaire;
        private string Titulaire
        {
            get { return b_titulaire; }
            set { b_titulaire = value;  }
        }

        private double b_solde;
        private double Solde
        {
            get { return b_solde; }
            set { b_solde = value; }
        }

        private string b_devise;
        private string Devise
        {
            get { return b_devise; }
            set { b_devise = value; }
        }

        private static int numberOfCompte;

        public compteBancaire(string titulaire, double solde, string devise)
        {
            this.b_titulaire = titulaire;
            this.b_solde = solde;
            this.b_devise = devise;
        }

        public void Crediter(double montant)
        {
            double newMontant = this.b_solde + montant;
            this.b_solde = newMontant;
        }

        public void Debiter(double montant)
        {
            double newMontant = this.b_solde - montant;
            this.b_solde = newMontant;
        }

        public void Decrire()
        {
            Console.WriteLine("Le titulaire est : " + b_titulaire + " Le solde est : " + b_solde + " La devise est : " + b_devise);
        }

    }*/
}
