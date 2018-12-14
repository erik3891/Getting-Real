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

            Vare vare = new Vare();   //instance til at gå ind i Classen Vare
            vare.ShowVare();

            Console.Write("2. Medarbejder : ");
            string Medarbejder = Console.ReadLine();

            Console.WriteLine("Tryk 1 for STARK konto");
            Console.WriteLine("Tryk 2 for Ingen STARK konto");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Kunde kunder = new Kunde();
                kunder.Showkunde();
                Console.WriteLine("Indtast Kunde ID");
                string kundID = Console.ReadLine();

            }
            else if (input =="2")
            {
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
            else
            {
                Console.WriteLine("Ugyldigt valg tryk Enter.");
                Console.ReadLine();
                return;
            }
        }
    }
}
