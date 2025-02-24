// See https://aka.ms/new-console-template for more information

using Examen;

Console.WriteLine("Singleton");

//Creamos 2 instancias de la clase
Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

s1.ShowMessage();
        
//Terminan siendo la misma ya que nomas se puede crea
Console.WriteLine(s1 == s2);

Console.WriteLine("Singleton");


