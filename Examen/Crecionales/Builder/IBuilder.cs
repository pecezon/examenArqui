namespace Examen;


//Interfaz que nos permite crear una instancia por partes
public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    Product GetResult();
}