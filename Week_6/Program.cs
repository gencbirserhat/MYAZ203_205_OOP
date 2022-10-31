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

            while (kHealth > 0 && eHealth > 0  )
            {
                
                knight.Attack(ref eHealth, ref kStamina);
                enemy.Attack(ref kHealth, ref eStamina);
                if (kHealth<0)
                {
                    kHealth = 0;
                    Console.WriteLine($"{enemy.Name,5}: {eHealth,10} --- {knight.Name,5}: {kHealth,12}\nEnemy Stamina: {eStamina,3} --- Charachter Stamina: {kStamina,2}\n-------------------------------------------- ");
                }
                else if (eHealth< 0)
                {
                    eHealth = 0;
                    Console.WriteLine($"{enemy.Name,5}: {eHealth,10} --- {knight.Name,5}: {kHealth,12}\nEnemy Stamina: {eStamina,3} --- Charachter Stamina: {kStamina,2}\n-------------------------------------------- ");
                }
                else
                {
                    Console.WriteLine($"{enemy.Name,5}: {eHealth,10} --- {knight.Name,5}: {kHealth,12}\nEnemy Stamina: {eStamina,3} --- Charachter Stamina: {kStamina,2}\n-------------------------------------------- ");
                }
               
            }
            if (eHealth > kHealth)
            {
                Console.WriteLine(($"{enemy.Name} wın").ToUpper());
            }
            else
            {
                Console.WriteLine(($"{knight.Name} wın").ToUpper());
            }
        }
    }
}