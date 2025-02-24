namespace Examen.Estructurales;

public abstract class Decorator : IComponentDec
{
    protected IComponentDec ComponentDec;

    protected Decorator(IComponentDec componentDec)
    {
        ComponentDec = componentDec;
    }

    public virtual void Operation()
    {
        ComponentDec.Operation();
    }
}