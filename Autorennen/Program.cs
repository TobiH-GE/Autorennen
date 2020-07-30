using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorennen
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Audi = new Auto(50, 123, 130);
            Gelaendewagen Jeep = new Gelaendewagen(80, 432, 100, true);

            Audi.ZeigeDaten();
            Jeep.ZeigeDaten();

            Audi.NeueGeschindigkeit = 20;
            Jeep.NeueGeschindigkeit = 30;

            Audi.ZeigeDaten();
            Jeep.ZeigeDaten();
            Console.ReadKey();
        }
    }
}