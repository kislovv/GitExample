namespace ChainOfResponsibility;

public class GetProductHandler:BaseHandler<Order>
{
    public GetProductHandler(IHandler<Order>? succeser) : base(succeser)
    {
    }
    public override void Handle(Order element)
    {
        Console.WriteLine(element.ToString());
        base.Handle(element);
        
    }
}