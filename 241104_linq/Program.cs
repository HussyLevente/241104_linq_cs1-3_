using _241104_linq;
using System.Text;

List<Versenyzok> versenyzo = new List<Versenyzok>();

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    versenyzo.Add(new(sr.ReadLine()));
}

//CS3

var f1 = versenyzo.Count(v => v.Kategoria == "25-29");
Console.WriteLine($"Versenyzők száma 25-29 kategóriában: {f1} fő");


var f2 = versenyzo.Average(v => 2014 - v.Szul);
Console.WriteLine($"A versenyzők átlagéletkora: {f2:0.00}");


var f3 = versenyzo.Sum(v => v.VersenyIdok["úszás"].TotalHours);
Console.WriteLine($"Úszással töltött összidő órában: {f3:0.00} óra");


var f4 = versenyzo.Where(v => v.Kategoria == "elit").Average(v => v.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"Elit kategóriában az átlagos úszással töltött idő: {f4:0.00} perc");


var f5 = versenyzo.Where(v => v.Nem).MinBy(v => v.OsszIdo);
Console.WriteLine($"Férfi győztes: {f5}");


var f6 = versenyzo.GroupBy(v => v.Kategoria);
Console.WriteLine("A versenyt befejezők kategóriánként: ");
foreach (var grp in f6)
{
    Console.WriteLine($"\t{grp.Key}: {grp.Count()} fő");
}

//CS1


var cs1f1 = versenyzo.Count(v => v.Kategoria == "elit");
Console.WriteLine($"Versenyzők száma elit kategóriában: {cs1f1} fő");


var cs1f2 = versenyzo.Where(v => !v.Nem).Average(v => 2014 - v.Szul);
Console.WriteLine($"A női versenyzők átlagéletkora: {cs1f2:0.00}");


var cs1f3 = versenyzo.Sum(v => v.VersenyIdok["kerékpár"].TotalHours);
Console.WriteLine($"Kerékpározással töltött összidő órában: {cs1f3:0.00} óra");


var cs1f4 = versenyzo.Where(v => v.Kategoria == "elit junior").Average(v => v.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"Elit junior kategóriában az átlagos úszással töltött idő: {cs1f4:0.00} perc");


var cs1f5 = versenyzo.Where(v => v.Nem).MinBy(v => v.OsszIdo);
Console.WriteLine($"Férfi győztes: {cs1f5}");


var cs1f6 = versenyzo.GroupBy(v => v.Kategoria);
Console.WriteLine("A versenyt befejeők száma korkategoriánként: ");
foreach (var g in cs1f6)
{
    Console.WriteLine($"\t{g.Key}: {g.Count()} fő");
}
