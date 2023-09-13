using system;
class Main
{
    static void Main()
    {
        Interval interval1 = new Interval(1, 5);
        Interval interval2 = new Interval(3, 7);

        Console.WriteLine("Interval 1 contains 4: " + interval1.Contains(4));
        Console.WriteLine("Interval 2 contains 8: " + interval2.Contains(8));

        Interval intersection = Interval.FindIntersection(interval1, interval2);
        Console.WriteLine("Intersection of intervals: " + (intersection != null ? $"{intersection.Start}-{intersection.End}" : "None"));

        Trojuhelnik trojuhelnik = new Trojuhelnik(3, 4, 5);
        Console.WriteLine("Je rovnostranny: " + trojuhelnik.JeRovnostranny());
        Console.WriteLine("Je rovnoramenny: " + trojuhelnik.JeRovnoramenny());
        Console.WriteLine("Je pravouhly: " + trojuhelnik.JePravouhly());

        Primka usecka = new Primka(new Point(1, 2), new Point(4, 6));
        Console.WriteLine("Delka usecky: " + usecka.Delka());

        Potravina jidlo = new Potravina
        {
            Nazev = "Hamburger",
            Hmotnost = 150,
            EnergetickaHodnotaKcal = 300
        };

        double denniMinPrijemKcal = 2000;

        Console.WriteLine($"Potravina: {jidlo.Nazev}");
        Console.WriteLine($"Energeticka hodnota (kJ): {jidlo.EnergetickaHodnotaKJ}");
        Console.WriteLine($"Energeticka hodnota (kcal): {jidlo.EnergetickaHodnotaKcal}");
        Console.WriteLine($"Tvoøí {jidlo.ProcentDennihoMinKalorickehoPrijmu(denniMinPrijemKcal):0.##}% denního minimálního kalorického pøíjmu.");
    }
}