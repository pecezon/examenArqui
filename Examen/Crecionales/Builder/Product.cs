namespace Examen;

public class Product
{
    public string? PartA { get; set; }
    public string? PartB { get; set; }

    public void Show()
    {
        Console.WriteLine($"Producto construido con: {PartA} y {PartB}");
    }
}