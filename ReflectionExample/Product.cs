namespace ReflectionExample;

public class Product(decimal value, TypeOfProduct typeOfProduct)
{
    public decimal Value { get; } = value;
    public TypeOfProduct TypeOfProduct { get; set; } = typeOfProduct;


    public override string ToString()
    {
        return $"Доставляется продукт типа : {typeOfProduct.EnumToStringConvert()}  объемом {value}";
    }
}