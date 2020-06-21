using System;
namespace cours_C_Sharp
{
    public class Boucle
    {
        public static void Main(string[] args)
        {
            // 1
            for (int i = 0; i <= 20; i++)
            {

                Console.WriteLine(i * 2);
                if (i > 9)
                {
                    i = 21;
                }
            }

            // 2
            int nombre = 0;
            Console.WriteLine("Entrez un nombre pour X : ");
            nombre = (int.Parse(Console.ReadLine()));
            for (int i = 0; i < nombre; i++)
            {
                int resultat = i + i;
                Console.WriteLine("Le résultat est : " + resultat + " pour avoir choisie le chiffre : " + nombre);
            }

            // 3
            int nbr = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Entrez un nombre pour nbr" + i);
                nbr = (int.Parse(Console.ReadLine()));
                double moyenne = (nbr1 + nbr2 + nbr3 + nbr4 + nbr5) / 5;
            }

        }
    }
}