namespace AnimalHierarchy;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var dog = new Dog();
        var dogSound = dog.MakeSound();

        var eagle = new Eagle();
        var eagleSound = eagle.MakeSound();
        
        Console.WriteLine(dogSound);
        Console.WriteLine(eagleSound);
    }
}