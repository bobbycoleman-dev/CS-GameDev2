class Ranged : Enemy
{
    public int Distance { get; set; } = 5;

    public Ranged(string name) : base(name, 100) { }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance > 10)
        {
            base.PerformAttack(Target, ChosenAttack);
            return;
        }
        Console.WriteLine("Distance must be 10 or greater to perform an attack!\n");

    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"You performed Dash. Distance is now {Distance}.\n");
    }
}