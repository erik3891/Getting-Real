using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Ordre
    { 

        public void ShowOrdre()
        {
            Console.Clear();
            Console.WriteLine("Opret Ordre");
            Console.WriteLine("");

            Console.Write("1. Vare : ");
            Vare vare = new Vare();
            vare.ShowVare();

            Console.Write("2. Medarbejder : ");
            string Medarbejder = Console.ReadLine();

            Console.Write("3. Kunde Navn : ");
            string KundeNavn = Console.ReadLine();

            Console.Write("4. Email : ");
            string Email = Console.ReadLine();

            Console.Write("5. Adresse : ");
            string Adresse = Console.ReadLine();

            Console.Write("6. Telefon : ");
            string Telefon = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("0. Exit");
            Console.Clear();
        }
    }
}
