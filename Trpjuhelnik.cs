class Trojuhelnik
{
	public double A { get; }
	public double B { get; }
	public double C { get; }

	public Trojuhelnik(double a, double b, double c)
	{
		A = a;
		B = b;
		C = c;
	}

	public bool JeRovnostranny()
	{
		return A == B && B == C;
	}

	public bool JeRovnoramenny()
	{
		return A == B || A == C || B == C;
	}

	public bool JePravouhly()
	{
		double[] sides = { A, B, C };
		Array.Sort(sides);
		return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
	}
}

