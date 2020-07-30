using System;
using System.Collections.Generic;
using System.Text;

namespace Autorennen
{
    class Auto
    {
        protected int PS;
        protected int Startnummer;
        protected int Geschwindigkeit;
        public Auto(int PS, int Startnummer, int Geschwindigkeit)
        {
            this.PS = PS;
            this.Startnummer = Startnummer;
            this.Geschwindigkeit = Geschwindigkeit;
        }
        public virtual void ZeigeDaten()
        {
            Console.WriteLine("PS: {0} Startnummer: {1} Geschwindigkeit: {2}", PS, Startnummer, Geschwindigkeit);
        }
        public int NeueGeschindigkeit
        {
            get
            {
                return Geschwindigkeit;
            }
            set
            {
                this.Geschwindigkeit = NeueGeschindigkeit;
            }

        }
    }
}
