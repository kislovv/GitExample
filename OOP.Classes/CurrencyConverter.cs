namespace OOP.Classes;

public static class CurrencyConverter
{
    public static string Convert(this int amount)
    {
        if (amount % 100 > 10 && amount % 100 < 20)
        {
            return $"{amount} рублей";
        }
        if (amount % 10 > 1 && amount % 10 < 5)
        {
            return $"{amount} рубля";
        }
        if (amount % 10 == 1)
        {
            return $"{amount} рубль";
        }
        return $"{amount} рублей";
    }
}