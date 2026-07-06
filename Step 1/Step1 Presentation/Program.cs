//using system;

//namespace step1;

//public class typemaster
//{
//    public string name = "pouria";
//#pragma warning disable //showcase preprocessing directives
//    private int age = 33;
//#pragma warning restore
//    private bool adult = true;
//}

// namespace organizer; // one file-scoped namespace is allowed

//public class counter
//{
//    private int count = 1;
//    //private string count = "three"; //type can contain one definition at a time

//    public void count()
//    {
//        string localpronoun = "we";
//        // count = true; //conversion problem
//        // string count = "three"; //shadowing
//        console.writeline($"{localpronoun} have greeted {count} times.");
//        count++; //if count is string, it's a bad operand for ++ operator
//    }
//    // localpronoun = "you"; //scope
//}

//public static class program
//{
//    public static void main(string[] args)
//    {
//        var counter = new counter();
//        var world = "world!";

//var typemaster = new typemaster();
//var secondtypemaster = new typemaster();
//var anothertypemaster = typemaster;

//console.writeline(object.referenceequals(typemaster, anothertypemaster));
//console.writeline(object.referenceequals(typemaster, secondtypemaster));
//console.writeline(object.referenceequals(secondtypemaster, anothertypemaster));

//console.writeline($"hello, {typemaster.name}!");
//counter.count();
Console.WriteLine($"hello to everyone watching this lecture!");
//        counter.count();
//        console.writeline(string.format("hello, {0}", world));
//        counter.count();
#region
for (int i = 50; i >= 0; i--)
{
    Console.WriteLine($"iterator is now = {i}");
    if (i == 24)
    {
        Console.WriteLine("24! hooray!");
    }
    else
    {
        Console.WriteLine("maybe next time (*/ω＼*)");
    }
    i /= 2;
}
    //}
//}
#endregion

////press ctrl + k, u to uncomment

/*
 * this one is a multi-line comment
 */