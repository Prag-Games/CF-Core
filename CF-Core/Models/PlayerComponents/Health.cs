namespace CF_Core.Models.PlayerComponents;

public class Health
{
    private int MaxHealth { get; set; }
    private int CurrentHealth { get; set; }

    private Health(){}

    public Health(int maxHealth)
    {
        this.MaxHealth = maxHealth;
        this.CurrentHealth = maxHealth;
    }

    public Health(int maxHealth, int currentHealth)
    {
        this.MaxHealth = maxHealth;
        this.CurrentHealth = currentHealth;
    }

    public static Health Default()
    {
        var health = new Health
        {
            MaxHealth = 100,
            CurrentHealth = 100
        };

        return health;
    }

    public bool IsZero()
    {
        return CurrentHealth == 0;
    }

    public bool IsBelowZero()
    {
        return CurrentHealth < 0;
    }
}