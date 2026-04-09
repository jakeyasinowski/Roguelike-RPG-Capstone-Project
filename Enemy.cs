using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_RPG
{
        public class Enemy
        {
            protected string name;
            protected int health;
            protected int damage;

            public Enemy(string name, int health, int damage)
            {
                this.name = name;
                this.health = health;
                this.damage = damage;
            }

            public virtual string AttackPlayer(Player player)
            {
                player.TakeDamage(damage);
                return $"{name} attacks {player} for {damage} damage!";
            }
        }
    }
}
