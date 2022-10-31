namespace Week_6
{
    public abstract class Character
    {

        public abstract string? Name { get; set; }
        public abstract uint Health { get; set; }
        public abstract uint Stamina { get; set; }
        public abstract int Damage { get; set; }

        public abstract void Attack(ref int EnemyHealth, ref int CurrentStamina);
        public abstract void Wait();

    }
}