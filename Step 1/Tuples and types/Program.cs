using System;

namespace TuplesAndTypes;

class Program
{
    static void Main(string[] args)
    {
        var pt = (X: 1, Y: 2);
        var slope = (double)pt.Y / (double)pt.X;
        Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

        pt.X += 5;
        Console.WriteLine($"The point is now at {pt}.");

        var pt2 = pt with { Y = 10 };
        Console.WriteLine($"The point 'pt2' is at {pt2}.");
        Console.WriteLine(pt.CompareTo(pt2));

        var pt3 = new Point(1, 4);
        var pt4 = pt3 with { Y = 10 };
        pt4.Slope();
    }

    public record Point(int X, int Y)
    {
        public double Slope()
        {
            double slope = Y / X;
            Console.WriteLine(slope);
            return slope;
        }
    }
}
