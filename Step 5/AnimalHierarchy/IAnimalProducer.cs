namespace AnimalHierarchy;

internal interface IAnimalProducer<out T>
{
    T Produce();
}

internal class DogProducer : IAnimalProducer<Dog>
{
    public Dog Produce() => new Dog();
}
internal class EagleProducer : IAnimalProducer<Eagle>
{
    public Eagle Produce() => new Eagle();
}
internal class SharkProducer : IAnimalProducer<Shark>
{
    public Shark Produce() => new Shark();
}

internal class AnimalProducer : IAnimalProducer<Animal>
{
    public Animal Produce()
    {
        var random = new Random();

        return random.Next(3) switch
        {
            0 => new Dog(),
            1 => new Eagle(),
            _ => new Shark()
        };
    }
}