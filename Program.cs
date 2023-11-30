using HegyiKerekparName;
using VersenyTavNev;
using System.Text;

List<HegyiKerekpar> lista = new List<HegyiKerekpar>();

StreamReader sr = new StreamReader("../../../src/bukkm2019.txt", encoding: Encoding.UTF8);

var _ = sr.ReadLine();

while (!sr.EndOfStream)
{
    lista.Add(new HegyiKerekpar(sr.ReadLine()));
}

var f4 = (double)(691-lista.Count) / (double)691*100;
Console.WriteLine($"A versenyzők {f4} arányban teljesitették");

var f5 = lista.Where(x => x.Rajtszam.StartsWith("R") && x.Kategoria.EndsWith("n")).Count();
Console.WriteLine($"Rövidtávú versenyen elindult nők száma: {f5} fő");

var f6 = lista.Any(x => x.Ido.Hours >= 6);

Console.WriteLine($"{(f6 ? "Volt ilyen" : "Nem volt ilyen")}");

var f7 = lista.Where(x => x.Rajtszam.StartsWith("R") && x.Kategoria.EndsWith("f")).OrderBy(x => x.Ido.Hours).ToList().First();

Console.WriteLine($"{f7.Rajtszam} {f7.Nev}");

Dictionary<string, int> f8 = new Dictionary<string, int>();
foreach (var item in lista)
{
    if (f8.ContainsKey(item.Kategoria))
    {
        f8[item.Kategoria] += 1;
    }
    else
    {
        f8.Add(item.Kategoria, 1);
    }
    
}

foreach (var item in f8)
{
    Console.WriteLine(item);
}