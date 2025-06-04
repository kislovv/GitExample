namespace HeroBuilderExample;

public class HeroBuilder
{
    private Hero _hero;
    private int _freePoint = 10;
    public HeroBuilder(string name)
    {
        _hero = new Hero
        {
            Name = name,
            Hp = 100,
            Attack = 1,
            Mana = 100,
            Speed = 10,
        };
    }

    public HeroBuilder WithAgility(int agility)
    {
        if (agility + _hero.Power + _hero.Intelligence > 10)
        {
            throw new Exception("Использованы лишние очки");
        }

        _hero.Agility = agility;
        _hero.Speed += agility * 10;
        _freePoint -= agility;

        return this;
    }
    
    public HeroBuilder WithPower(int power)
    {
        if (power + _hero.Agility + _hero.Intelligence > 10)
        {
            throw new Exception("Использованы лишние очки");
        }

        _hero.Power = power;
        _hero.Attack += power;
        _freePoint -= power;
        
        return this;
    }
    
    public HeroBuilder WithIntelligence(int intelligence)
    {
        if (intelligence + _hero.Agility + _hero.Power > 10)
        {
            throw new Exception("Использованы лишние очки");
        }

        _hero.Intelligence = intelligence;
        _hero.Mana += intelligence * 100;
        _freePoint -= intelligence;
        
        return this;
    }


    public Hero Build()
    {
        return _hero;
    }
    
}