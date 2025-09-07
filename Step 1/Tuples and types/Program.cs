var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

pt.X += 5;
Console.WriteLine($"The point is now at {pt}.");

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

Console.WriteLine(pt.CompareTo(pt2));
