namespace Examen.Estructurales.Composite;

public class Composite : IComponent
{
    private readonly List<IComponent> _children = new();

    public void Add(IComponent component)
    {
        _children.Add(component);
    }

    public void Operation()
    {
        Console.WriteLine("Ejecutando operación en Composite.");
        foreach (var child in _children)
        {
            child.Operation();
        }
    }
}