namespace OOP.Classes;

public static class CurrencyConverter
{
    public static string RubleConverter(this decimal inputMoney)
    {
        var wholeMoney = (long)inputMoney;
        if (wholeMoney % 100 < 20 && 10 < wholeMoney % 100)
        {
            return "рублей";
        }
        if (wholeMoney % 10 == 1)
        {
            return "рубль";
        }
        if ((wholeMoney % 10) > 1 && (wholeMoney % 10) < 5)
        {
            return "рубля";
        }

        return "рублей";
    }
    public static string DollarConverter(this decimal inputMoney)
    {
        var wholeMoney = (long)inputMoney;
        
        return (wholeMoney % 100 < 20 && 10 < wholeMoney % 100)
            ? "долларов"
            : (wholeMoney % 10 == 1)
                ? "доллар"
                : ((wholeMoney % 10) > 1 && (wholeMoney % 10) < 5)
                    ? "доллара"
                    : "долларов";
    }
}

