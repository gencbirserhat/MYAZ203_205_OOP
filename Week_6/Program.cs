using System;

namespace Week_6
{
    class Program
    {
        static void Main()
        {
            Knight knight = new Knight("Sir Knight");
            Enemy enemy = new Enemy();

            var kHealth = knight.Health;
            var eHealth = enemy.Health;
            var kStamina = knight.Stamina;
            var eStamina = enemy.Stamina;

            Console.WriteLine($"***** First Enemy Stamina: {eStamina} --- First Charachter Stamina: {kStamina} *****\n");

            while (kHealth > 0 && eHealth > 0)
            {
                knight.Attack(ref eHealth, ref kStamina);
                enemy.Attack(ref kHealth, ref eStamina);
                Console.WriteLine($"Enemy: {eHealth,10} --- Charachter: {kHealth,10}\nEnemy Stamina: {eStamina} --- Charachter Stamina: {kStamina}\n-------------------------------------------- ");

            }
            if (eHealth > kHealth)
            {
                Console.WriteLine(("mıssıon faıled").ToUpper());
            }
            else
            {
                Console.WriteLine(("mıssıon completed").ToUpper());
            }

        }
    }
}