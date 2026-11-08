namespace AnimalHierarchy;

public abstract class Animal
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Eat() => "Yum Yum!";
    public string Sleep() => "Zzzzzzz!";
    public abstract string MakeSound();
}