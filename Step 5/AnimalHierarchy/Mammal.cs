namespace AnimalHierarchy;

public abstract class Mammal : Animal
{
    public abstract override string MakeSound();
    public string Feed() => "Breast feeding the baby";
}