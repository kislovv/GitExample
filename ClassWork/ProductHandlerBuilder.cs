using System.Collections.Generic;

namespace ClassWork;

public class ProductHandlerBuilder : HandlerBuilder<Product>
{
    public ProductHandlerBuilder(List<Product> products) :
        base(new StorageProductHandler(products))
    {
    }

    public ProductHandlerBuilder AddMarking()
    {
        AddHandler(new MarkingProductHandler());
        return this;
    }
    
    public ProductHandlerBuilder AddFinish()
    {
        AddHandler(new FinishProductHandler());
        return this;
    }
}