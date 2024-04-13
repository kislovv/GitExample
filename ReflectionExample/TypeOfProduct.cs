namespace ReflectionExample;
[EnumDescriptionAttribute("Тип доставляемого продукта")]
public enum TypeOfProduct
{
    [EnumDescriptionAttribute("масло")]
    Oil,
    [EnumDescriptionAttribute("газ")]
    Gaz,
    [EnumDescriptionAttribute("дерево")]
    Wood
}