namespace AnimalHierarchy;

interface IAnimalBuyer<in T>
{
    void Buy(T animal);
}