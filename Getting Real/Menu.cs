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
                            Kunde kunder = new Kunde();
                            kunder.Showkunde();
                            break;         
                        //case "3":
                        //    SaveMatch();
                        //    break;
                        //case "4":
                        //    Creatacount();
                        //    break;
                        default:
                            Console.WriteLine("Ugyldigt valg tryk Enter.");
                            Console.ReadLine();
                            Console.Clear();
                        break;
                    }
                } while (running);
            }
        private void ShowMenu()
        {
            Console.WriteLine("STARK INTERN ORDRE SYSTEM");
            Console.WriteLine();
            Console.WriteLine("1. Opret Ordre");
            Console.WriteLine("2. Kunde Liste");
            Console.WriteLine("3. Medarbejder list");
            Console.WriteLine("4. Opret STARK Konto");
            Console.WriteLine("");
            Console.WriteLine("0. Exit");
        }

        private string GetUserChoice()
        {
                Console.WriteLine();
                Console.Write("Indtast dit valg: ");
                return Console.ReadLine();
         }

     }
}

