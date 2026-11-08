namespace AnimalHierarchy;

public abstract class Fish : Animal
{
    public abstract override string MakeSound();
    public string Swim() => "Deep at the ocean";
}