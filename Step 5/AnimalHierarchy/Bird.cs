namespace AnimalHierarchy;

public abstract class Bird : Animal
{
    public abstract override string MakeSound();
    public string Fly() => "High at the skies!";
}