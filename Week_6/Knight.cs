﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    public class Knight : Character
    {
        private string? _name;
        private uint _health;
        private uint _stamina;
        private int _damage;
        public override string? Name
        {
            get => _name;
            set => _name = value;
        }
        public override uint Health
        {
            get => _health;
            set => _health = value;
        }
        public override uint Stamina
        {
            get => _stamina;
            set => _stamina = value;
        }
        public override int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public Knight(string? name)
        {
            Random damage = new Random();
            var RandomDamage = damage.Next(1, 21);
            Name = name;
            Health = 100;
            Stamina = 100;
            Damage = RandomDamage;
        }


        public override void Attack(ref int EnemyHealth, ref int CurrentStamina)
        {
            if (Stamina > 0)
            {
                EnemyHealth = EnemyHealth - Damage;

                CurrentStamina = CurrentStamina - 10;



            }
            else
            {
                Console.WriteLine("You are tired!");
                Wait();
            }
        }

        public override void Wait()
        {
            if (Stamina < 100)
            {
                Stamina += 15;
            }
        }
    }
}
