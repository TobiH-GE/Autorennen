using System;
using System.Collections.Generic;
using System.Text;

namespace Autorennen
{
    class Gelaendewagen : Auto
    {
        bool Allradantrieb;
        public Gelaendewagen(int PS, int Startnummer, int Geschwindigkeit, bool Allradantrieb) : base(PS, Startnummer, Geschwindigkeit)
        {
            this.Allradantrieb = Allradantrieb;
        }
        public override void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Startnummer: {1} Geschwindigkeit: {2} Allradantrieb: {3}", PS, Startnummer, Geschwindigkeit, Allradantrieb);
        }
    }
}
