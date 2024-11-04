
using csop2;
using System.Text;

List<Versenyzok> versenyzok = [];

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

var f1 = versenyzok.Count(v => v.kategoria == "elit junior");
Console.WriteLine($"elit junior versenyzok: {f1}");
var f2 = versenyzok.Where(v => v.nem).Average(v => DateTime.Now.Year - v.szul);
Console.WriteLine($"Női életkor átlag {f2:0.00}");
var f3 = versenyzok.Sum(v => v.versenyidok["úszás"].TotalHours);
Console.WriteLine($"Össz úszás időtartam: {f3:0:00}");
var f4 = versenyzok.Average(v => v.versenyidok["úszás"].TotalHours);
Console.WriteLine($"Versenyzők átlag úszása: {f4:0.00}");
var f5 = versenyzok.Where(v => !v.nem).MinBy(v => v.versenyidok.Sum(v => v.Value.TotalSeconds));
Console.WriteLine($"női győztes: {f5}");
var f6 = versenyzok.GroupBy(v => v.nem).OrderBy(v => v.Key);
foreach (var f in f6)
{
    Console.WriteLine($"{(f.Key ? "Férfi" : "Nő")}: {f.Count()}");
}
//--------------------------------
var f7 = versenyzok.Count(v => v.kategoria == "25-29");
Console.WriteLine($"25-29 kategóriában lévő versenyzők száma {f7}");
var f8 = versenyzok.Average(v => DateTime.Now.Year - v.szul );
Console.WriteLine($"Versenyzők átlag életkora: {f8:0.00}");
var f9 = versenyzok.Sum(v => v.versenyidok["úszás"].TotalHours);
Console.WriteLine($"Össz úszás időtartam: {f3:0:00}");
var f10 = versenyzok.Where(v=>v.kategoria=="elit junior").Average(v => v.versenyidok["úszás"].TotalHours);
Console.WriteLine($"Versenyzők átlag úszása: {f4:0.00}");
var f11 = versenyzok.Where(v => v.nem).MinBy(v => v.versenyidok.Sum(v => v.Value.TotalSeconds));
Console.WriteLine($"Férfi győztes: {f5}");
var f12 = versenyzok.GroupBy(v => v.nem).OrderBy(v => v.Key);
foreach (var f in f12)
{
    Console.WriteLine($"{(f.Key ? "Férfi" : "Nő")}: {f.Count()}");
}