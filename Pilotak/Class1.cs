using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    internal class Class1
    {
        string nev;
        string szuldate;
        string nemzetiseg;
        int rajtszam;

        public Class1(string nev, string szuldate, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuldate = szuldate;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Szuldate { get => szuldate; set => szuldate = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}
