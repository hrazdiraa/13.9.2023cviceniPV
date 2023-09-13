class Primka
{
    public Point PocatecniBod { get; }
    public Point KoncovyBod { get; }

    public Primka(Point pocatecniBod, Point koncovyBod)
    {
        PocatecniBod = pocatecniBod;
        KoncovyBod = koncovyBod;
    }

    public double Delka()
    {
        return Math.Sqrt(Math.Pow(KoncovyBod.X - PocatecniBod.X, 2) + Math.Pow(KoncovyBod.Y - PocatecniBod.Y, 2));
    }
}
