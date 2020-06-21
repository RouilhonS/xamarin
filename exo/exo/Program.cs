using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace exo
{
    public class Program
    {

        public class ClasseChaine
        {

            public string Nom = "Rouilhon";
            public string Prenom = "Steven";

            public void RetourneInitial(string Nom, string Prenom)
            {
                string initiale = Nom[0] + "." + Prenom[0];
            }
        }

        // Test
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(initiale))
            {
                return string.Empty;
            }
        }

    }
}