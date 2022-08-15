// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();


public class AnimalWorld
{
    private Herbivore _herbivore;
    private Carnivore _carnivore;
    // Constructor
    public AnimalWorld(ContinentFactory factory)
    {
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}
//Abstract factory
public abstract class ContinentFactory
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
// Family one
public abstract class Herbivore
{

}
//Family Tow
public abstract class Carnivore
{
    public abstract void Eat(Herbivore hebovore);
}
// Concreate member in family in america
public class Wildebeest : Herbivore
{

}
public class Lion : Carnivore
{
    public override void Eat(Herbivore hebovore)
    {
        Console.WriteLine($"{this.GetType().Name} eats {hebovore.GetType().Name}");
    }
}

public class Bison : Herbivore
{

}
public class Wolf : Carnivore
{
    public override void Eat(Herbivore h)
    {
        // Eat Bison
        Console.WriteLine($"{this.GetType().Name} eats {h.GetType().Name}");
    }
}

public class AfricaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}
public class AmericaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}