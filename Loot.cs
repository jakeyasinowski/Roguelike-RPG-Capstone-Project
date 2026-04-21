using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_RPG
{
    public class Loot
    {
        // Loot Variables
        protected string name;
        public int addHealth;
        public int addDamage;

        // Loot Default Constructor
        public Loot(string name, int addHealth, int addDamage)
        {
            this.name = name;
            this.addHealth = addHealth;
            this.addDamage = addDamage;
        }
        
        // Lists stats of loot obtained
        public virtual string ItemDescription()
        {
            return $"Loot: {name}\n Health: +{addHealth}\n Damage: +{addDamage}";
        }
    }
}
