using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lada = new Auto("piros", "Lada 2112", 11);
            Auto trabant= new Auto("zöld","Trabant 1.1",8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();
            Console.WriteLine("Mennyit megy a Lada? ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            lada.Allapot();
            
            Console.ReadKey();
        }
    }
}
