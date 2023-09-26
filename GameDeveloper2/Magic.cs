class Magic : Enemy
{
    public Magic(string name) : base(name, 80) { }

    public void Heal(Enemy Target)
    {
        int MeleeHealth = 120;
        int RangedHealth = 100;
        int MagicHealth = 80;

        switch (Target)
        {
            case Melee:
                if (Target.Health + 40 > MeleeHealth)
                {
                    Target.Health = MeleeHealth;
                    Console.WriteLine($"{Target.Name}'s health has been increased to max of {MeleeHealth}\n");
                }
                else
                {
                    Target.Health += 40;
                    Console.WriteLine($"{Target.Name}'s health has been increased to {Target.Health}\n");
                }
                break;
            case Ranged:
                if (Target.Health + 40 > RangedHealth)
                {
                    Target.Health = RangedHealth;
                    Console.WriteLine($"{Target.Name}'s health has been increased to max of {RangedHealth}\n");
                }
                else
                {
                    Target.Health += 40;
                    Console.WriteLine($"{Target.Name}'s health has been increased to {Target.Health}\n");
                }
                break;
            case Magic:
                if (Target.Health + 40 > MagicHealth)
                {
                    Target.Health = MagicHealth;
                    Console.WriteLine($"{Target.Name}'s health has been increased to max of {MagicHealth}\n");
                }
                else
                {
                    Target.Health += 40;
                    Console.WriteLine($"{Target.Name}'s health has been increased to {Target.Health}\n");
                }
                break;
            default:
                break;
        }
    }
}