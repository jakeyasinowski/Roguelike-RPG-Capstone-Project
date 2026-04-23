using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_RPG
{
        public class Enemy
        {
            // Enemy variable
            protected string name;
            protected int health;
            protected int damage;
            public bool enemyDead = false;

            public Enemy(string name, int health, int damage) // Default constructor
            {
                this.name = name;
                this.health = health;
                this.damage = damage;
            }


            public void TakeDamage(Player player) // Reduces based on player damage
            {
                health -= player.playerDamage;
                Console.WriteLine($"{player.name} attacks {name} for {player.playerDamage} damage!\n");


                if (health < 0)
                {
                    enemyDead = true;
                }

                   
            }

            public void AttackPlayer(Player player) // Damages the player
            {
                player.TakeDamage(damage);
                Console.WriteLine($"{name} attacks {player.name} for {damage} damage!\n");

                if (player.playerDead)
                {
                    Console.WriteLine("Game over. you lost");
                }
        }

            public int GetCurrentHealth() // Returns enemys current health
            {
                return health;
            }
    
    }
}
