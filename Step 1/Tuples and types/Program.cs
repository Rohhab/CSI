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
        Console.WriteLine($"The comparison of pt and pt2 results in: {pt.CompareTo(pt2)}");

        var pt3 = new Point(1, 4);
        Point pt4;

        if (pt3.X == 1 && pt3.Y == 4)
        {
            pt4 = pt3 with { Y = 10 };
            while (pt4.Slope() > 2)
            {
                pt4 = pt4 with { Y = pt4.Y - 1 };
                Console.WriteLine($"Lowering the Y value of pt4 to {pt4.Y}");
            }
        }
    }

    public record Point(int X, int Y)
    {
        public double Slope()
        {
            return Y / X;
        }
    }
}
