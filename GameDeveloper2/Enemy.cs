class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; set; } = new();

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public Attack RandomAttack()
    {
        Random attack = new();
        Attack randAttack = AttackList[attack.Next(AttackList.Count - 1)];
        return randAttack;
        // Console.WriteLine($"Attack: {randAttack.Name}\nDamage Dealt: {randAttack.DamageAmount}");
    }

    public void AddAttack(Attack NewAttack)
    {
        AttackList.Add(NewAttack);
    }

    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} cannot attack {Target.Name} because {Name} is dead. Sorry.\n");
            return;
        }

        if (Target.Health > 0)
        {
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!\n");
            return;
        }

        Console.WriteLine($"{Target.Name} is dead. You cannot attack this target.\n");
    }


}