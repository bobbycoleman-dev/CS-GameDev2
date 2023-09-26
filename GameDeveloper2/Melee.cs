class Melee : Enemy
{
    public Melee(string name) : base(name, 120) { }

    public void Rage(Enemy Target)
    {
        Attack RandAttack = RandomAttack();
        RandAttack.DamageAmount += 10;
        Console.WriteLine($"Random attack is {RandAttack.Name}. Rage increased its damage by 10 to {RandAttack.DamageAmount}.\n");
        PerformAttack(Target, RandAttack);
        RandAttack.DamageAmount -= 10;
        Console.WriteLine($"Rage ended. {RandAttack}'s damage is back to {RandAttack.DamageAmount}.\n");
    }
}