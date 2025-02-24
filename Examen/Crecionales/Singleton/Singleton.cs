namespace Examen;

public class Singleton
{
    //Atributo de la instancia de la propia clase
    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        //Si no se ha creado una instancia antes se crea una, sino se retorna la ya creada anteriormente
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Soy una instancia única.");
    }
}