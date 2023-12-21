using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Software sf1 = new Software("ko","b","nok");
            sf1.ChangeAccess("g");
            sf1.ChangeAccess("p");

            sf1.ShowInf();

            sf1.J(sf1.Access); 
           
            Console.ReadKey();
        }
    }
}
