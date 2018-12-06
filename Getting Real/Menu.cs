using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{

    public class Menu
        {
            public void Show()
            {
                bool running = true;
                do
                {
                    ShowMenu();
                    string choice = GetUserChoice();
                    switch (choice)
                    {
                        case "0":
                            running = false;
                            break;
                        case "1":
                            Ordre ordre = new Ordre();
                            ordre.ShowOrdre();
                            break;
                        case "2":
                            //ScheduleNewRound();
                            break;
                        case "3":
                            //SaveMatch();
                            break;
                        case "4":
                            //Creatacount();
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg.");
                            Console.ReadLine();
                            break;
                    }
                } while (running);
            }
        private void ShowMenu()
        {
            Console.WriteLine("STARK INTERN ORDRE SYSTEM");
            Console.WriteLine();
            Console.WriteLine("1. Opret Ordre");
            Console.WriteLine("2. Lager");
            Console.WriteLine("3. Medarbejder list");
            Console.WriteLine("4. Opret STARK Konto");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
            Console.Clear();
        }

        //private void ShowOrdre()
        //    {
        //    Console.WriteLine("Opret Ordre");
        //    Console.WriteLine("");
        //    Console.Write("1. Medarbejder : ");
        //    string Medarbejder = Console.ReadLine(); 
        //    Console.Write("2. Kunde Navn : ");
        //    string KundeNavn = Console.ReadLine();
        //    Console.Write("3. Email : ");
        //    string Email = Console.ReadLine(); 
        //    Console.Write("4. Adresse : ");
        //    string Adresse = Console.ReadLine();
        //    Console.Write("5. Telefon : ");
        //    string Telefon = Console.ReadLine();
        //    Console.Write("6. Vare");
        //    string 
        //    Console.WriteLine("0. Exit");
        //    Console.Clear();
        //}
        private string GetUserChoice()
            {
                Console.WriteLine();
                Console.Write("Indtast dit valg: ");
                return Console.ReadLine();
            }

     }
}

