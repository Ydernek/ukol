using Evidence_pojištěných;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class VypisPojistenych
{
    private NovyPojisteny novyPojisteny;

    public VypisPojistenych(NovyPojisteny pojisteni)
    {
        novyPojisteny = pojisteni;
    }

    //dojde k vypsání všech pojištěných
    public void Vypis()
    {
        for (int i = 0; i < novyPojisteny.jmeno.Count; i++)
        {
            Console.WriteLine($"{novyPojisteny.jmeno[i].PadRight(10)} {novyPojisteny.prijmeni[i].PadRight(10)} {novyPojisteny.vek[i]} \t {novyPojisteny.telefonniCislo[i]}");
        }
        Console.WriteLine("\nPokračujte libovolnou klávesou...");
        Console.ReadKey();
    }
}

