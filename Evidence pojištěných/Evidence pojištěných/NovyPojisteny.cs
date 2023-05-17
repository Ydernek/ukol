using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištěných
{
    internal class NovyPojisteny
    {
        public List<string> jmeno = new List<string>();
        public List<string> prijmeni = new List<string>();
        public List<int> telefonniCislo = new List<int>();
        public List<int> vek = new List<int>();

        public void Pridani()
        {
            //zadáme pojištěného, dojde ke kontrole na prázdné pole nebo enter
            Console.WriteLine("Zadejte jméno pojištěného:");
            string vlozJmeno = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(vlozJmeno))
            {
                Console.WriteLine("Jméno nesmí být prázdné nebo obsahovat pouze mezery. Zadejte text znovu:");
                vlozJmeno = Console.ReadLine();
            }
            jmeno.Add(vlozJmeno);


            //zadáme pojištěného, dojde ke kontrole na prázdné pole nebo enter
            Console.WriteLine("Zadejte příjmení pojištěného:");
            string vlozPrijmeni = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(vlozPrijmeni))
            {
                Console.WriteLine("Příjmení nesmí být prázdné nebo obsahovat pouze mezery. Zadejte text znovu:");
                vlozPrijmeni = Console.ReadLine();
            }
            prijmeni.Add(vlozPrijmeni);


            //zadáme pojištěného telefon, dojde ke kontrole na prázdné pole nebo enter
            Console.WriteLine("Zadejte telefonní číslo:");
            string telefonniCisloText = Console.ReadLine();
            int telefonniCislohodnota;

            while (!int.TryParse(telefonniCisloText, out telefonniCislohodnota))
            {
                Console.WriteLine("Telefonní číslo musí být celé číslo. Zadejte text znovu:");
                telefonniCisloText = Console.ReadLine();
            }
            telefonniCislo.Add(telefonniCislohodnota);


            //zadáme věk, dojde ke kontrole na prázdné pole nebo enter
            Console.WriteLine("Zadejte věk");
            int vekZadany;
            while (!int.TryParse(Console.ReadLine(), out vekZadany))
            {
                Console.WriteLine("Věk musí být celé číslo. Zadejte věk znovu:");
            }
            vek.Add(vekZadany);

            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }
    }
}
