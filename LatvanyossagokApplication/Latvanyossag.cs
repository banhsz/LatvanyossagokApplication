using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossag
    {
        private int id;
        private string nev;
        private string leiras;
        private int ar;
        private int varosId;

        public Latvanyossag(int id, string nev, string leiras, int ar, int varosId)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varosId = varosId;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Ar { get => ar; set => ar = value; }
        public int VarosId { get => varosId; set => varosId = value; }
    }
}
