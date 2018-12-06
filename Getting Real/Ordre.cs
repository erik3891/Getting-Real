using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace Getting_Real
{
    public class Ordre
    { 

        public void ShowOrdre()
        {
            Console.WriteLine("Opret Ordre");
            Console.WriteLine("");
            Console.Write("1. Medarbejder : ");
            string Medarbejder = Console.ReadLine();

            Console.Write("2. Kunde Navn : ");
            string KundeNavn = Console.ReadLine();

            Console.Write("3. Email : ");
            string Email = Console.ReadLine();
            Console.Write("4. Adresse : ");
            string Adresse = Console.ReadLine();
            Console.Write("5. Telefon : ");
            string Telefon = Console.ReadLine();
            Console.Write("6. Vare");
            string Vare = Console.ReadLine();
            Console.WriteLine("0. Exit");
            Console.Clear();
        }
    }
}
