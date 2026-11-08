namespace AnimalHierarchy;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var monkey = new Mammal();
        var mammalSound = monkey.MakeSound();

        var owl = new Bird();
        var birdSound = owl.MakeSound();
        
        Console.WriteLine(mammalSound);
        Console.WriteLine(birdSound);
    }
}