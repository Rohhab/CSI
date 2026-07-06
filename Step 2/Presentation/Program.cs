using System;

namespace Presentation;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Type Showcase: Class, Struct, Record\n");

            // STEP 1: CLASS

            /*
            var c1 = new Counter("c1");
            var c2 = new Counter("c2");
            var c3 = c1;
            Console.WriteLine($"TotalCount: {Counter.TotalCount}");
            Console.WriteLine($"Are c1 & c2 equal? {c1 == c2}");
            Console.WriteLine($"Are c1 & c3 equal? {c1 == c3}");
            */

            // STEP 2: STRUCT

            /*
            var p1 = new Point(3, 4);
            var p2 = p1; // Value copy
            p2.X = 10;
            Console.WriteLine($"p1: ({p1.X}, {p1.Y})");
            Console.WriteLine($"p2: ({p2.X}, {p2.Y})");
            Console.WriteLine($"p1 recheck: ({p1.X}, {p1.Y})");
            */
            

            // STEP 3: RECORD

            
            var person1 = new Person("Pouria", "Metal");

            // The with expression lets us create a copy with one or more changes
            var person2 = person1 with { Name = "Karen" };
            var person3 = new Person("Pouria", "Metal");
            Console.WriteLine($"person1: {person1}");
            Console.WriteLine($"{person1.Name}'s favorite music genre is {person1.FavoriteMusicGenre}");
            Console.WriteLine($"{person2.Name}'s favorite music genre is {person2.FavoriteMusicGenre}");
            Console.WriteLine($"Are person1 and person2 equal? {person1 == person2}");
            Console.WriteLine($"Are person1 and person3 equal? {person1 == person3}");
            

            // Console Repeat and Cleanup
            #region
            Console.WriteLine("\nPress any key to run again, or press Esc to exit...");
            var key = Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.Escape) break;
            Console.Clear();
            #endregion
        }
    }
}

// CLASS
// Classes are reference types with reference-based equality.
public class Counter
{
    public Counter(string name)
    {
        Console.WriteLine($"{name}: {this.GetNextValue()}");
    }

    private int _count = 50;
    private static int _totalCount;

    public int GetNextValue()
    {
        _count += 1;
        _totalCount += 1;
        return _count;
    }

    public static int TotalCount => _totalCount;
}

// STRUCT
// Structs are value types with value-based equality.
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// RECORD
// Records are reference types like classes, but with value-based equality.
public record Person(string Name, string FavoriteMusicGenre);