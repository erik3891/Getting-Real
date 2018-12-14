using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Getting_Real
{
    class Kunde
    {
        private static string connection = "Server=eal.local; Database=C_DB11_2018; User Id=C_STUDENT11; Password=C_OPENDB11";
        public void Showkunde()
        {
            Console.WriteLine("Indtast Kunde ID");
            string kundID = Console.ReadLine();
            return;
        }
    }
}
