namespace Examen;

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.PartA = "Parte A construida";
    }

    public void BuildPartB()
    {
        _product.PartB = "Parte B construida";
    }

    public Product GetResult()
    {
        return _product;
    }
}