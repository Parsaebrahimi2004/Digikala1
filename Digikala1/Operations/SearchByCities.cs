using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala1.Operations
{
    internal class SearchByCities
    {
        static string address1 = @"D:\digikala dataset\orders.csv";

        static void SBC(string DGkl)
        {
            StreamReader digikala = new StreamReader(address1);

            StreamWriter digikalatehran = new StreamWriter("tehran_orders.csv");
            StreamWriter digikalaesfahan = new StreamWriter("esfahan_orders.csv");
            StreamWriter digikalakaraj = new StreamWriter("karaj_orders.csv");
            StreamWriter digikalamashhad = new StreamWriter("mashhad_orders.csv");

            string Orders;

            while (!digikala.EndOfStream)
            {
                Orders = digikala.ReadLine();
                if (Orders.Contains("تهران"))
                {
                    digikalatehran.WriteLine(Orders);
                }
                if (Orders.Contains("اصفهان"))
                {
                    digikalaesfahan.WriteLine(Orders);
                }
                if (Orders.Contains("کرج"))
                {
                    digikalakaraj.WriteLine(Orders);
                }
                if (Orders.Contains("مشهد"))
                {
                    digikalamashhad.WriteLine(Orders);
                }
            }

            
            digikalatehran.Close();
            digikalaesfahan.Close();
            digikalakaraj.Close();
            digikalamashhad.Close();
        }
    }}

