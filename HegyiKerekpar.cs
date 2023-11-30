using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HegyiKerekparName
{
    class HegyiKerekpar
    {
        public string Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public TimeSpan Ido { get; set; }


        public HegyiKerekpar(string sor)
        {
            string[] data = sor.Split(';');
            this.Rajtszam = data[0];
            this.Kategoria = data[1];
            this.Nev = data[2];
            this.Egyesulet = data[3];
            var ido = (data[4].Split(":"));
            this.Ido = new TimeSpan(int.Parse(ido[0]), int.Parse(ido[1]), int.Parse(ido[2]));
        }

    }
}
