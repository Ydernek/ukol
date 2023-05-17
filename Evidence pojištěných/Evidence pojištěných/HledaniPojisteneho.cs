using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Evidence_pojištěných
{
    internal class HledaniPojisteneho
    {
        public void Hledat(NovyPojisteny novyPojisteny)
        {
            //zadáme jméno a následně ho uložíme
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(jmeno))
            {
                Console.WriteLine("Zadej text znovu:");
                jmeno = Console.ReadLine();
            }


            //zadáme příjmení uživatele a následně ho uložíme
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string prijmeni = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(prijmeni))
            {
                Console.WriteLine("Zadej text znovu:");
                prijmeni = Console.ReadLine();
            }

            /*hledáme pojištěného. Pokud ho nenajdeme, tak konzole vypíše, že nebyl nalezen.
            V případě, že ho najdeme, tak vypíše jeho údaje*/
            int hledanyPojisteny = novyPojisteny.jmeno.IndexOf(jmeno);
            if (hledanyPojisteny == -1 || novyPojisteny.prijmeni[hledanyPojisteny] != prijmeni)
            {
                Console.WriteLine("Pojištěný nebyl nalezen.");
            }
            else
            {
                Console.WriteLine($"\n{novyPojisteny.jmeno[hledanyPojisteny].PadRight(10)} {novyPojisteny.prijmeni[hledanyPojisteny].PadRight(10)} {novyPojisteny.vek[hledanyPojisteny]} \t {novyPojisteny.telefonniCislo[hledanyPojisteny]}");

                Console.WriteLine("\nPokračujte libovolnou klávesou...");
            }

            Console.ReadKey();
        }
    }
}
