namespace ChainOfResponsibility;

public class MarkingProductHandler: BaseHandler<Order>
{
    public MarkingProductHandler(IHandler<Order>? succeser) : base(succeser)
    {
    }
    public override void Handle(Order element)
    {
        element.Number = Guid.NewGuid();
        Console.WriteLine(element.Number);
        base.Handle(element);
    }
}