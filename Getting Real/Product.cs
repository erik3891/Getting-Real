using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Product
    {
        public void ShowProduct()
        {
            Console.Write("1. Vare : ");
            string additem = Console.ReadLine();

            bool run = true;

            if (additem != "")
            {
                while (run)
                {
                    Console.Write("Antal : ");
                    string nextadditem = Console.ReadLine();
                    if (nextadditem == "")
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" . Vare : ");
                        string lastadditem = Console.ReadLine();
                        if (lastadditem == "")
                        {
                            break;
                        }
                    }
                }


            }
            else
            {
                return;
            }
        }

        }
    }
