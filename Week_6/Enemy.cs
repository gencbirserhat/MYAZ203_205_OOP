using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_6
{
    public class Enemy : Character
    {
        private string? _name;
        private int _health;
        private int _stamina;
        private int _damage;

        public override string? Name
        {
            get => _name;
            set => _name = value;
        }
        public override int Health
        {
            get => _health;
            set => _health = value;
        }
        public override int Stamina
        {
            get => _stamina;
            set => _stamina = value;
        }
        public override int Damage
        {
            get => _damage;
            set => _damage = value;
        }


        public Enemy()
        {
            Name = "Thanos";
            Random damage = new Random();
            var RandomDamage = damage.Next(1, 21);
            Health = 100;
            Stamina = 100;
            Damage = RandomDamage;
        }

        public override void Attack(ref int EnemyHealth, ref int CurrentStamina)
        {
            if (CurrentStamina > 0)
            {
                EnemyHealth = EnemyHealth - Damage;

                CurrentStamina = CurrentStamina - 5;
            }
            else
            {
                Wait(ref CurrentStamina);
            }
        }

        public override void Wait(ref int CurrentStamina)
        {
            while (CurrentStamina < 100)
            {
                CurrentStamina += 10;
            }
        }
    }
}
