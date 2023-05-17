using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištěných
{
    internal class Volby
    {
        private NovyPojisteny novyPojisteny = new NovyPojisteny();
        private VypisPojistenych vypisPojistenych;
        HledaniPojisteneho hledaniPojisteneho = new HledaniPojisteneho();


        public void NazevVolby() 
        {

            int volba = 0;

            while (volba != 4)
            {
                //menu formuláře, dojde k parsování
                Console.Clear();        // vyčiští formulář od předchozího textu
                Console.WriteLine("---------------------------\nEvidence pojištěných\n---------------------------\n");
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");

                //vyžádání čísla 1-4 od uživatele
                if (!int.TryParse(Console.ReadLine(), out volba))
                {
                    Console.WriteLine("Neplatná volba, zadejte číslo od 1 do 4.");
                    continue;
                }

                //jednotlivé volby programu
                switch (volba)
                {
                    case 1:
                        novyPojisteny.Pridani();
                        break;
                    case 2:
                        vypisPojistenych = new VypisPojistenych(novyPojisteny);
                        vypisPojistenych.Vypis();
                        break;
                    case 3:
                        hledaniPojisteneho.Hledat(novyPojisteny);
                        break;
                    case 4:
                        Console.WriteLine("\nDěkujeme za použití programu");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zadejte číslo od 1 do 4.");
                        break;
                }
                
                //Console.ReadKey();
                
            }
        }
    }
}
