namespace Examen.Estructurales;

public class ConcreteDecoratorDec : Decorator
{
    public ConcreteDecoratorDec(IComponentDec componentDec) : base(componentDec) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Funcionalidad adicional añadida por el decorador.");
    }
}