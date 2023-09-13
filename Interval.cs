using system;
class Interval
{
    public int Start { get; set; }
    public int End { get; set; }

    public Interval(int start, int end)
    {
        this.Start = start;
        this.End = end;
    }

    public bool Contains(int value)
    {
        return value >= Start && value <= End;
    }

    public static Interval FindIntersection(Interval interval1, Interval interval2)
    {
        int start = Math.Max(interval1.Start, interval2.Start);
        int end = Math.Min(interval1.End, interval2.End);

        if (start <= end)
        {
            return new Interval(start, end);
        }

        return null;
    }
}