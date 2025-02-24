namespace Examen.Comportamiento.Strategy;

public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Estrategia A ejecutada.");
    }
}