// See https://aka.ms/new-console-template for more information

using Examen;
using Examen.Comportamiento;
using Examen.Comportamiento.Command;
using Examen.Comportamiento.Strategy;
using Examen.Crecionales.Factory;
using Examen.Estructurales;
using Examen.Estructurales.Adapter;
using Examen.Estructurales.Composite;

Console.WriteLine("Singleton");

//Creamos 2 instancias de la clase
Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

s1.ShowMessage();
        
//Terminan siendo la misma ya que nomas se puede crea
Console.WriteLine(s1 == s2);

Console.WriteLine("Builder");

Director director = new Director();
IBuilder builder = new ConcreteBuilder();

director.Construct(builder);
Product product = builder.GetResult();

product.Show();

Console.WriteLine("Factory Method");

//Creas las instancias de los 2 tipos de producto que derivan de la misma interfaz
Creator creatorA = new ConcreteCreatorA();
IProduct productA = creatorA.FactoryMethod();
productA.ShowInfo();

Creator creatorB = new ConcreteCreatorB();
IProduct productB = creatorB.FactoryMethod();
productB.ShowInfo();

Console.WriteLine("Adapter");

//Usas la clase adapter para adaptar los metodos del adaptador
Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);

adapter.Request();

Console.WriteLine("Composite");

//Un arbol sencillo es una forma buena de utilizar este patron ya que este se COMPONE  de hojas que nosotros anadimos
Composite root = new Composite();
root.Add(new Leaf("A"));
root.Add(new Leaf("B"));

Composite subTree = new Composite();
subTree.Add(new Leaf("C"));

root.Add(subTree);
root.Operation();

Console.WriteLine("Decorator");

IComponentDec component = new ConcreteComponentDec();
IComponentDec decoratedComponent = new ConcreteDecoratorDec(component);

decoratedComponent.Operation();

Console.WriteLine("Observer");

ConcreteSubject subject = new();
IObserver observer1 = new ConcreteObserver("Observador 1");
IObserver observer2 = new ConcreteObserver("Observador 2");

subject.Attach(observer1);
subject.Attach(observer2);

subject.Notify("¡Nuevo evento ocurrió!");

subject.Detach(observer1);
subject.Notify("Otro evento ocurrió.");

Console.WriteLine("Strategy");

Context context = new(new ConcreteStrategyA());
context.ExecuteStrategy();

context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

Console.WriteLine("Command");

Receiver receiver = new();
ICommand command = new ConcreteCommand(receiver);
Invoker invoker = new();

invoker.SetCommand(command);
invoker.ExecuteCommand();
