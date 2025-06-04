namespace HeroBuilderExample;

public class Hero
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Intelligence { get; set; }
    public int Hp { get; set; }
    public int Speed { get; set; }
    public int Agility { get; set; }
    public int Power { get; set; }
    public int Mana { get; set; }
    public int Attack { get; set; }

    public override string ToString()
    {
        return $"{Name}: HP-{Hp}, Mana-{Mana}, Speed-{Speed}, Attack-{Attack}";
    }
}