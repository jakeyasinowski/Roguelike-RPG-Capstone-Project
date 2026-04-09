using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_RPG
{
    public class Player
    {
        // Player Variables
        protected string name;
        protected int maxPlayerHealth;
        protected int playerHealth;
        protected int playerDamage;

        // Default Player Constructor
        public Player(string name, int maxPlayerHealth, int playerDamage)
        {
            this.name = name;
            this.maxPlayerHealth = maxPlayerHealth;
            this.playerHealth = maxPlayerHealth;
            this.playerDamage = playerDamage;
        }

        public void TakeDamage(int amount) // Reduces health by enemy damage amount
        {
            playerHealth -= amount;
            if (playerHealth < 0)
            {
                Console.WriteLine("You died. \nGame Over");
            } 
        }

        public virtual void ListPlayerStats() // Lists players current stats
        {
            Console.WriteLine($"Player: {name}");
            Console.WriteLine($"Max Health: {maxPlayerHealth}");
            Console.WriteLine($"Current Health: {playerHealth}");
            Console.WriteLine($"Damage: {playerDamage}");
        }

        public virtual void UpdatePlayerStats(int addHealth, int addDamage) // Updates players current stats
        {
            maxPlayerHealth += addHealth;
            playerDamage += addDamage;
        }
    }
}
