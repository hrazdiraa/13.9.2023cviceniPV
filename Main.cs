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
    }
}