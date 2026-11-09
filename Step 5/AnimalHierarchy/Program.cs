using System.Reflection.Metadata;

namespace AnimalHierarchy;

internal partial class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var dogProducer = new DogProducer();
        var eagleProducer = new EagleProducer();
        var sharkProducer = new SharkProducer();

        IAnimalProducer<Animal> animalProducer1 = dogProducer;
        IAnimalProducer<Animal> animalProducer2 = eagleProducer;
        IAnimalProducer<Animal> animalProducer3 = sharkProducer;

        var dog = animalProducer1.Produce();
        var eagle = animalProducer2.Produce();
        var shark = animalProducer3.Produce();

        Console.WriteLine(dog.MakeSound());
        Console.WriteLine(eagle.MakeSound());
        Console.WriteLine(shark.MakeSound());
    }
}