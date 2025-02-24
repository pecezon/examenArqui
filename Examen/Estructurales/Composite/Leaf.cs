namespace Examen.Estructurales.Composite;

public class Leaf : IComponent
{
    private readonly string _name;

    public Leaf(string name)
    {
        _name = name;
    }

    public void Operation()
    {
        Console.WriteLine($"Hoja {_name} ejecutando operación.");
    }
}