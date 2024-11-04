using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csop2
{
    internal class Versenyzok
    {
        public string nev { get; set; }
        public int szul { get; set; }
        public string rajtszam { get; set; }
        public bool nem { get; set; }
        public string kategoria { get; set; }
        public Dictionary<string, TimeSpan> versenyidok { get; set; }
        public override string ToString() =>
        $"[{rajtszam} {nev} ({(nem ? "Férfi" : "Nő")}, {kategoria},)]";


        public Versenyzok(string sor)
        {
            string[] v = sor.Split(';');
            nev = v[0];
            szul = int.Parse(v[1]);
            rajtszam = v[2];
            nem = v[3] == "f";
            kategoria = v[4];

            versenyidok = new()
        {
            {"úszás",TimeSpan.Parse(v[5])},
            {"I. Depó",TimeSpan.Parse(v[6])},
            {"kerékpár",TimeSpan.Parse(v[7])},
            {"II. Depó",TimeSpan.Parse(v[8])},
            {"futás",TimeSpan.Parse(v[9])}
        };
        }
    }
}
