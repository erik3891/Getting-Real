using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Getting_Real
{
    public class Customer
    {
        private static string connection = "Server=eal.local; Database=C_DB11_2018; User Id=C_STUDENT11; Password=C_OPENDB11";
        //using SqlConnection con = new SqlConnection(connection);
        //try {

        //}
        //catch {

        //}

    public void ShowCustomer()
        {
            Console.WriteLine("Indtast Kunde ID");
            string kundID = Console.ReadLine();
            Console.Clear();
            return;
        }
    }            
}   