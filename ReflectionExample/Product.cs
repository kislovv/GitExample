namespace ReflectionExample;

public class Product(decimal value, TypeOfProduct typeOfProduct)
{
    public decimal Value { get; } = value;
    public TypeOfProduct TypeOfProduct { get; set; } = typeOfProduct;


    public override string ToString()
    {
        return $"Доставляется продукт типа : {typeOfProduct.EnumToStringConvert()}  объемом {value}";
    }


    [MethodVersion("v1")]
    public string Method1()
    {
        return "v1";
    }
    
    [MethodVersion("v2")]
    public string Method2()
    {
        return "v2";
    }
    
    [MethodVersion("v3")]
    [MethodVersion("v5")]
    [MethodVersion("v6")]
    public string Method3()
    {
        return "v3";
    }
    
    [MethodVersion("v4")]
    public string Method4()
    {
        return "v4";
    }
}