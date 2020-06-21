using System;
namespace cours_C_Sharp
{
    public class Classe
    {
        // Execrice 1
        public class CompteBancaire
        {
            private string b_titulaire;
            private string Titulaire
            {
                get { return b_titulaire; }
                set { b_titulaire = value; }
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

            public CompteBancaire(string titulaire, double solde, string devise)
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

        }

        // Exercide 2
        public class Client
        {
            private int CIN;
            private string Nom;
            public string Prenom;
            private string Tel;

            public Client(int cin, string nom, string prenom, string tel)
            {
                this.CIN = cin;
                this.Nom = nom;
                this.Prenom = prenom;
                this.Tel = tel;
            }
            public void Afficher()
            {
                Console.WriteLine("Le client est : " + Prenom + " " + Nom + ", son CIN est : " + CIN + " et sont téléphone est : " + Tel);
            }
        }

        public class Compte : Client
        {
            double solde
            {
                get;
            }
            int code
            {
                get;
            }
            public Compte(double solde, int code)
                : base(1, "Rouilhon", "Steven", "06")
            {
                this.solde = solde;
                this.code = code;
            }
        }

        // Exercide 3
        public class Article
        {
            private int Reference
            {
                get { return Reference; }
                set { Reference = value; }
            }
            private string Designation
            {
                get { return Designation; }
                set { Designation = value; }
            }
            public double PrixHT
            {
                get { return PrixHT; }
                set { PrixHT = value; }
            }
            public double TauxTVA
            {
                get { return TauxTVA; }
                set { TauxTVA = value; }
            }
        }
    }
}