using System;

namespace ClassWork;

public class Order
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }


    public override string ToString()
    {
        return $"{Id}, {Name}, {Category}, {Count}, {Price}";
    }
}